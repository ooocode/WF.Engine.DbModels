namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiProcinst
{
    public string Id { get; set; } = null!;

    public string ProcInstId { get; set; } = null!;

    public string BusinessKey { get; set; }

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? RemovalTime { get; set; }

    public long? Duration { get; set; }

    public string StartUserId { get; set; }

    public string StartActId { get; set; }

    public string EndActId { get; set; }

    public string SuperProcessInstanceId { get; set; }

    public string RootProcInstId { get; set; }

    public string SuperCaseInstanceId { get; set; }

    public string CaseInstId { get; set; }

    public string DeleteReason { get; set; }

    public string TenantId { get; set; }

    public string State { get; set; }
}
