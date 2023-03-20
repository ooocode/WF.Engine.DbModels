namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiIdentitylink
{
    public string Id { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string Type { get; set; }

    public string UserId { get; set; }

    public string GroupId { get; set; }

    public string TaskId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcDefId { get; set; }

    public string OperationType { get; set; }

    public string AssignerId { get; set; }

    public string ProcDefKey { get; set; }

    public string TenantId { get; set; }

    public DateTime? RemovalTime { get; set; }
}
