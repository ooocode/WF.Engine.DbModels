namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuCaseSentryPart
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string CaseInstId { get; set; }

    public string CaseExecId { get; set; }

    public string SentryId { get; set; }

    public string Type { get; set; }

    public string SourceCaseExecId { get; set; }

    public string StandardEvent { get; set; }

    public string Source { get; set; }

    public string VariableEvent { get; set; }

    public string VariableName { get; set; }

    public bool? Satisfied { get; set; }

    public string TenantId { get; set; }

    public virtual ActRuCaseExecution CaseExec { get; set; }

    public virtual ActRuCaseExecution CaseInst { get; set; }
}
