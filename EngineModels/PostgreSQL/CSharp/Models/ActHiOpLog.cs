namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiOpLog
{
    public string Id { get; set; } = null!;

    public string DeploymentId { get; set; }

    public string ProcDefId { get; set; }

    public string ProcDefKey { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string ExecutionId { get; set; }

    public string CaseDefId { get; set; }

    public string CaseInstId { get; set; }

    public string CaseExecutionId { get; set; }

    public string TaskId { get; set; }

    public string JobId { get; set; }

    public string JobDefId { get; set; }

    public string BatchId { get; set; }

    public string UserId { get; set; }

    public DateTime Timestamp { get; set; }

    public string OperationType { get; set; }

    public string OperationId { get; set; }

    public string EntityType { get; set; }

    public string Property { get; set; }

    public string OrgValue { get; set; }

    public string NewValue { get; set; }

    public string TenantId { get; set; }

    public DateTime? RemovalTime { get; set; }

    public string Category { get; set; }

    public string ExternalTaskId { get; set; }

    public string Annotation { get; set; }
}
