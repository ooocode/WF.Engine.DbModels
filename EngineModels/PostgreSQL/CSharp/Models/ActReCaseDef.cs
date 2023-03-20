namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActReCaseDef
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

    public string TenantId { get; set; }

    public int? HistoryTtl { get; set; }

    public virtual ICollection<ActRuCaseExecution> ActRuCaseExecutions { get; } = new List<ActRuCaseExecution>();

    public virtual ICollection<ActRuTask> ActRuTasks { get; } = new List<ActRuTask>();
}
