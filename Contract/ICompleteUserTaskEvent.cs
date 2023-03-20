using WF.Engine.DbModels.EngineModels;
using WF.Engine.DbModels.EngineModels.ExtendModels;

namespace WF.Engine.DbModels.Contract
{
    public interface ICompleteUserTaskEvent
    {
        Task ExecuteAsync(CompletedUserTask task,
            EngineDbContext engineDbContext,
            CancellationToken cancellationToken);
    }
}
