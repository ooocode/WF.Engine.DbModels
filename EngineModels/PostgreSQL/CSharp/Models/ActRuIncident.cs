namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuIncident
{
    public string Id { get; set; } = null!;

    public int Rev { get; set; }

    public DateTime IncidentTimestamp { get; set; }

    public string IncidentMsg { get; set; }

    public string IncidentType { get; set; } = null!;

    public string ExecutionId { get; set; }

    public string ActivityId { get; set; }

    public string FailedActivityId { get; set; }

    public string ProcInstId { get; set; }

    public string ProcDefId { get; set; }

    public string CauseIncidentId { get; set; }

    public string RootCauseIncidentId { get; set; }

    public string Configuration { get; set; }

    public string TenantId { get; set; }

    public string JobDefId { get; set; }

    public string Annotation { get; set; }

    public virtual ActRuIncident CauseIncident { get; set; }

    public virtual ActRuExecution Execution { get; set; }

    public virtual ICollection<ActRuIncident> InverseCauseIncident { get; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuIncident> InverseRootCauseIncident { get; } = new List<ActRuIncident>();

    public virtual ActRuJobdef JobDef { get; set; }

    public virtual ActReProcdef ProcDef { get; set; }

    public virtual ActRuExecution ProcInst { get; set; }

    public virtual ActRuIncident RootCauseIncident { get; set; }
}
