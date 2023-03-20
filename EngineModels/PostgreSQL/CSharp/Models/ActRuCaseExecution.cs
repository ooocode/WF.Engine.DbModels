namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuCaseExecution
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string CaseInstId { get; set; }

    public string SuperCaseExec { get; set; }

    public string SuperExec { get; set; }

    public string BusinessKey { get; set; }

    public string ParentId { get; set; }

    public string CaseDefId { get; set; }

    public string ActId { get; set; }

    public int? PrevState { get; set; }

    public int? CurrentState { get; set; }

    public bool? Required { get; set; }

    public string TenantId { get; set; }

    public virtual ICollection<ActRuCaseSentryPart> ActRuCaseSentryPartCaseExecs { get; } = new List<ActRuCaseSentryPart>();

    public virtual ICollection<ActRuCaseSentryPart> ActRuCaseSentryPartCaseInsts { get; } = new List<ActRuCaseSentryPart>();

    public virtual ICollection<ActRuTask> ActRuTasks { get; } = new List<ActRuTask>();

    public virtual ICollection<ActRuVariable> ActRuVariableCaseExecutions { get; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuVariable> ActRuVariableCaseInsts { get; } = new List<ActRuVariable>();

    public virtual ActReCaseDef CaseDef { get; set; }

    public virtual ActRuCaseExecution CaseInst { get; set; }

    public virtual ICollection<ActRuCaseExecution> InverseCaseInst { get; } = new List<ActRuCaseExecution>();

    public virtual ICollection<ActRuCaseExecution> InverseParent { get; } = new List<ActRuCaseExecution>();

    public virtual ActRuCaseExecution Parent { get; set; }
}
