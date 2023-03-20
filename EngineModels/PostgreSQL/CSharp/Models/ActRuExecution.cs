namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuExecution
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string BusinessKey { get; set; }

    public string ParentId { get; set; }

    public string ProcDefId { get; set; }

    public string SuperExec { get; set; }

    public string SuperCaseExec { get; set; }

    public string CaseInstId { get; set; }

    public string ActId { get; set; }

    public string ActInstId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsConcurrent { get; set; }

    public bool? IsScope { get; set; }

    public bool? IsEventScope { get; set; }

    public int? SuspensionState { get; set; }

    public int? CachedEntState { get; set; }

    public long? SequenceCounter { get; set; }

    public string TenantId { get; set; }

    public virtual ICollection<ActRuEventSubscr> ActRuEventSubscrs { get; } = new List<ActRuEventSubscr>();

    public virtual ICollection<ActRuExtTask> ActRuExtTasks { get; } = new List<ActRuExtTask>();

    public virtual ICollection<ActRuIncident> ActRuIncidentExecutions { get; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuIncident> ActRuIncidentProcInsts { get; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuTask> ActRuTaskExecutions { get; } = new List<ActRuTask>();

    public virtual ICollection<ActRuTask> ActRuTaskProcInsts { get; } = new List<ActRuTask>();

    public virtual ICollection<ActRuVariable> ActRuVariableExecutions { get; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuVariable> ActRuVariableProcInsts { get; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuExecution> InverseParent { get; } = new List<ActRuExecution>();

    public virtual ICollection<ActRuExecution> InverseProcInst { get; } = new List<ActRuExecution>();

    public virtual ICollection<ActRuExecution> InverseSuperExecNavigation { get; } = new List<ActRuExecution>();

    public virtual ActRuExecution Parent { get; set; }

    public virtual ActReProcdef ProcDef { get; set; }

    public virtual ActRuExecution ProcInst { get; set; }

    public virtual ActRuExecution SuperExecNavigation { get; set; }
}
