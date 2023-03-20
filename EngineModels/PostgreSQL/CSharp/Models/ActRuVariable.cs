namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuVariable
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ExecutionId { get; set; }

    public string ProcInstId { get; set; }

    public string ProcDefId { get; set; }

    public string CaseExecutionId { get; set; }

    public string CaseInstId { get; set; }

    public string TaskId { get; set; }

    public string BatchId { get; set; }

    public string BytearrayId { get; set; }

    public double? Double { get; set; }

    public long? Long { get; set; }

    public string Text { get; set; }

    public string Text2 { get; set; }

    public string VarScope { get; set; }

    public long? SequenceCounter { get; set; }

    public bool? IsConcurrentLocal { get; set; }

    public string TenantId { get; set; }

    public virtual ActRuBatch Batch { get; set; }

    public virtual ActGeBytearray Bytearray { get; set; }

    public virtual ActRuCaseExecution CaseExecution { get; set; }

    public virtual ActRuCaseExecution CaseInst { get; set; }

    public virtual ActRuExecution Execution { get; set; }

    public virtual ActRuExecution ProcInst { get; set; }
}
