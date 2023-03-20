namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuJobdef
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string ProcDefId { get; set; }

    public string ProcDefKey { get; set; }

    public string ActId { get; set; }

    public string JobType { get; set; } = null!;

    public string JobConfiguration { get; set; }

    public int? SuspensionState { get; set; }

    public long? JobPriority { get; set; }

    public string TenantId { get; set; }

    public string DeploymentId { get; set; }

    public virtual ICollection<ActRuBatch> ActRuBatchBatchJobDefs { get; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuBatch> ActRuBatchMonitorJobDefs { get; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuBatch> ActRuBatchSeedJobDefs { get; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuIncident> ActRuIncidents { get; } = new List<ActRuIncident>();
}
