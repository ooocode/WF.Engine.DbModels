namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiTaskinst
{
    public string Id { get; set; } = null!;

    public string TaskDefKey { get; set; }

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string ExecutionId { get; set; }

    public string CaseDefKey { get; set; }

    public string CaseDefId { get; set; }

    public string CaseInstId { get; set; }

    public string CaseExecutionId { get; set; }

    public string ActInstId { get; set; }

    public string Name { get; set; }

    public string ParentTaskId { get; set; }

    public string Description { get; set; }

    public string Owner { get; set; }

    public string Assignee { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public long? Duration { get; set; }

    public string DeleteReason { get; set; }

    public int? Priority { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public string TenantId { get; set; }

    public DateTime? RemovalTime { get; set; }
}
