using Engine;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Quartz;

namespace WF.Engine.DbModels.Jobs
{
    internal class GprcClientInterceptor : Interceptor
    {
        private readonly ISchedulerFactory schedulerFactory;
        private readonly ILogger<GprcClientInterceptor> logger;
        private readonly IHostEnvironment hostEnvironment;

        public GprcClientInterceptor(ISchedulerFactory schedulerFactory,
            ILogger<GprcClientInterceptor> logger,
            IHostEnvironment hostEnvironment)
        {
            this.schedulerFactory = schedulerFactory;
            this.logger = logger;
            this.hostEnvironment = hostEnvironment;
        }


        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            if (context.Method.Name == nameof(ProcessService.ProcessServiceClient.CompleteUserTask))
            {
                var response = continuation(request, context);
                var task = MyAsyncStuff(response);
                return new AsyncUnaryCall<TResponse>(task,
                    response.ResponseHeadersAsync,
                    response.GetStatus,
                    response.GetTrailers,
                    response.Dispose);
            }
            else
            {
                return base.AsyncUnaryCall(request, context, continuation);
            }
        }

        private async Task<TResponse> MyAsyncStuff<TResponse>(AsyncUnaryCall<TResponse> responseAsync)
        {
            var res = await responseAsync;
            try
            {
                var jobKey = new JobKey(Jobs.UserTaskEventJob.JobKey);
                var scheduler = await schedulerFactory.GetScheduler();
                var exist = await scheduler.CheckExists(jobKey);
                if (exist)
                {
                    var trigger = TriggerBuilder.Create()
                        .ForJob(new JobKey(Jobs.UserTaskEventJob.JobKey))
                        .StartNow()
                        .Build();
                    await scheduler.ScheduleJob(trigger);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "触发器创建失败");
            }

            return res;
        }
    }
}
