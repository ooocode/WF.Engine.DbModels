namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiExtTaskLog
{
    public string Id { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string ExtTaskId { get; set; } = null!;

    public int? Retries { get; set; }

    public string TopicName { get; set; }

    public string WorkerId { get; set; }

    public long Priority { get; set; }

    public string ErrorMsg { get; set; }

    public string ErrorDetailsId { get; set; }

    public string ActId { get; set; }

    public string ActInstId { get; set; }

    public string ExecutionId { get; set; }

    public string ProcInstId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcDefId { get; set; }

    public string ProcDefKey { get; set; }

    public string TenantId { get; set; }

    public int? State { get; set; }

    public DateTime? RemovalTime { get; set; }
}
