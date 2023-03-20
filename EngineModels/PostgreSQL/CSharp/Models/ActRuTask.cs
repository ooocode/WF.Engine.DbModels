using WF.Engine.DbModels.EngineModels.ExtendFields;

namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuTask : RuTask
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string ExecutionId { get; set; }

    public string ProcInstId { get; set; }

    public string ProcDefId { get; set; }

    public string CaseExecutionId { get; set; }

    public string CaseInstId { get; set; }

    public string CaseDefId { get; set; }

    public string Name { get; set; }

    public string ParentTaskId { get; set; }

    public string Description { get; set; }

    public string TaskDefKey { get; set; }

    public string Owner { get; set; }

    public string Assignee { get; set; }

    public string Delegation { get; set; }

    public int? Priority { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public int? SuspensionState { get; set; }

    public string TenantId { get; set; }

    public virtual ICollection<ActRuIdentitylink> ActRuIdentitylinks { get; } = new List<ActRuIdentitylink>();

    public virtual ActReCaseDef CaseDef { get; set; }

    public virtual ActRuCaseExecution CaseExecution { get; set; }

    public virtual ActRuExecution Execution { get; set; }

    public virtual ActReProcdef ProcDef { get; set; }

    public virtual ActRuExecution ProcInst { get; set; }
}
