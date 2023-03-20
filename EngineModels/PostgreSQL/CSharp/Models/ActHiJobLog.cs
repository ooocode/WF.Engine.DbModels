namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiJobLog
{
    public string Id { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string JobId { get; set; } = null!;

    public DateTime? JobDuedate { get; set; }

    public int? JobRetries { get; set; }

    public long JobPriority { get; set; }

    public string JobExceptionMsg { get; set; }

    public string JobExceptionStackId { get; set; }

    public int? JobState { get; set; }

    public string JobDefId { get; set; }

    public string JobDefType { get; set; }

    public string JobDefConfiguration { get; set; }

    public string ActId { get; set; }

    public string FailedActId { get; set; }

    public string ExecutionId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcessInstanceId { get; set; }

    public string ProcessDefId { get; set; }

    public string ProcessDefKey { get; set; }

    public string DeploymentId { get; set; }

    public long? SequenceCounter { get; set; }

    public string TenantId { get; set; }

    public string Hostname { get; set; }

    public DateTime? RemovalTime { get; set; }
}
