namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiActinst
{
    public string Id { get; set; } = null!;

    public string ParentActInstId { get; set; }

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; } = null!;

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; } = null!;

    public string ExecutionId { get; set; } = null!;

    public string ActId { get; set; } = null!;

    public string TaskId { get; set; }

    public string CallProcInstId { get; set; }

    public string CallCaseInstId { get; set; }

    public string ActName { get; set; }

    public string ActType { get; set; } = null!;

    public string Assignee { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public long? Duration { get; set; }

    public int? ActInstState { get; set; }

    public long? SequenceCounter { get; set; }

    public string TenantId { get; set; }

    public DateTime? RemovalTime { get; set; }
}
