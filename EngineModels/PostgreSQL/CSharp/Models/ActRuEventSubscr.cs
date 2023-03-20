namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuEventSubscr
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string EventType { get; set; } = null!;

    public string EventName { get; set; }

    public string ExecutionId { get; set; }

    public string ProcInstId { get; set; }

    public string ActivityId { get; set; }

    public string Configuration { get; set; }

    public DateTime Created { get; set; }

    public string TenantId { get; set; }

    public virtual ActRuExecution Execution { get; set; }
}
