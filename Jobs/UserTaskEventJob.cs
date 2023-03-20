using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quartz;
using WF.Engine.DbModels.Contract;
using WF.Engine.DbModels.EngineModels;
using WF.Engine.DbModels.EngineModels.ExtendModels;

namespace WF.Engine.DbModels.Jobs
{
    [DisallowConcurrentExecution]
    public class UserTaskEventJob : IJob
    {
        public const string JobKey = "UserTaskEvent";

        private readonly IDbContextFactory<EngineDbContext> contextFactory;
        private readonly IEnumerable<ICompleteUserTaskEvent> userTaskEvents;
        private readonly ILogger<UserTaskEventJob> logger;

        public UserTaskEventJob(ILogger<UserTaskEventJob> logger,
            IDbContextFactory<EngineDbContext> contextFactory,
            IEnumerable<ICompleteUserTaskEvent> userTaskEvents)
        {
            this.logger = logger;
            this.contextFactory = contextFactory;
            this.userTaskEvents = userTaskEvents;
        }

        private async Task<(CompletedUserTask task, EngineDbContext fetchDbContext)>
            FetchTaskAsync(CancellationToken cancellationToken)
        {
            var now = DateTimeOffset.UtcNow;
            try
            {
                var engineDbContext = await contextFactory.CreateDbContextAsync(cancellationToken);
                CompletedUserTask completedUserTask = await engineDbContext.CompletedUserTasks
                    .Where(e => e.LockEndDateTime == null || e.LockEndDateTime < now)
                    .OrderByDescending(e => e.Retries)
                    .ThenBy(e => e.CreateDateTimeOffset)
                    .FirstOrDefaultAsync(cancellationToken);
                if (completedUserTask == null)
                {
                    return (null, null);
                }

                completedUserTask.LockEndDateTime = now.AddMinutes(15);
                completedUserTask.LastExecuteDateTimeOffset = now;
                completedUserTask.Retries++;
                await engineDbContext.SaveChangesAsync(cancellationToken);
                return (completedUserTask, engineDbContext);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "FetchTaskAsync");
            }
            return (null, null);
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var cancellationToken = context.CancellationToken;
            var (completedUserTask, fecthDbContext) = await FetchTaskAsync(cancellationToken);
            if (completedUserTask == null)
            {
                await Task.Delay(5000);
                return;
            }

            var startTime = DateTimeOffset.UtcNow;
            logger.LogInformation($"{startTime}" +
                $" 开始处理：{completedUserTask.BusinessKey}");
            try
            {
                using var dbContext = await contextFactory.CreateDbContextAsync(cancellationToken);
                using var transaction = await dbContext.Database.BeginTransactionAsync(cancellationToken);

                //运行事件任务
                if (userTaskEvents.Any())
                {
                    foreach (var item in userTaskEvents)
                    {
                        await item.ExecuteAsync(completedUserTask,
                            dbContext,
                            context.CancellationToken);
                    }
                }

                List<string> nextUserTaskIds = completedUserTask.NextUserTasks.Split(';').Where(e => !string.IsNullOrEmpty(e)).ToList();
                //设置任务为启用状态
                await dbContext.ActRuTasks
                    .Where(e => nextUserTaskIds.Contains(e.Id))
                    .ExecuteUpdateAsync(e =>
                        e.SetProperty(p => p.Enabled, true), cancellationToken);

                //删除完成的任务
                await dbContext.CompletedUserTasks
                    .Where(e => e.Id == completedUserTask.Id)
                    .ExecuteDeleteAsync(cancellationToken);

                await dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                var endTime = DateTimeOffset.UtcNow;
                var timeSpan = endTime - startTime;
                logger.LogInformation($"{endTime}: " +
                    $"成功处理完成的用户任务 " +
                    $"{completedUserTask.BusinessKey} " +
                    $"用时 {timeSpan}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UserTaskEventJob发生错误");
                if (completedUserTask != null && fecthDbContext != null)
                {
                    try
                    {
                        var errorMsg = ex.InnerException?.Message ?? ex.Message;
                        await fecthDbContext.CompletedUserTasks
                             .Where(e => e.Id == completedUserTask.Id)
                             .ExecuteUpdateAsync(e => e.SetProperty(p => p.FaildReason, errorMsg));
                    }
                    catch (Exception exex)
                    {
                        logger.LogWarning(exex, "UpdateCompletedUserTasks发生错误");
                    }
                }
            }
            finally
            {
                fecthDbContext.Dispose();
            }
        }
    }
}
