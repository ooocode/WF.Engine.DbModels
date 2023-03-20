namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiVarinst
{
    public string Id { get; set; } = null!;

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string ExecutionId { get; set; }

    public string ActInstId { get; set; }

    public string CaseDefKey { get; set; }

    public string CaseDefId { get; set; }

    public string CaseInstId { get; set; }

    public string CaseExecutionId { get; set; }

    public string TaskId { get; set; }

    public string Name { get; set; } = null!;

    public string VarType { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? Rev { get; set; }

    public string BytearrayId { get; set; }

    public double? Double { get; set; }

    public long? Long { get; set; }

    public string Text { get; set; }

    public string Text2 { get; set; }

    public string TenantId { get; set; }

    public string State { get; set; }

    public DateTime? RemovalTime { get; set; }
}
