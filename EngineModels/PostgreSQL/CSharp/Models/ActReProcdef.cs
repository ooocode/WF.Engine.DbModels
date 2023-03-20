namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActReProcdef
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Category { get; set; }

    public string Name { get; set; }

    public string Key { get; set; } = null!;

    public int Version { get; set; }

    public string DeploymentId { get; set; }

    public string ResourceName { get; set; }

    public string DgrmResourceName { get; set; }

    public bool? HasStartFormKey { get; set; }

    public int? SuspensionState { get; set; }

    public string TenantId { get; set; }

    public string VersionTag { get; set; }

    public int? HistoryTtl { get; set; }

    public bool? Startable { get; set; }

    public virtual ICollection<ActRuExecution> ActRuExecutions { get; } = new List<ActRuExecution>();

    public virtual ICollection<ActRuIdentitylink> ActRuIdentitylinks { get; } = new List<ActRuIdentitylink>();

    public virtual ICollection<ActRuIncident> ActRuIncidents { get; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuTask> ActRuTasks { get; } = new List<ActRuTask>();
}
