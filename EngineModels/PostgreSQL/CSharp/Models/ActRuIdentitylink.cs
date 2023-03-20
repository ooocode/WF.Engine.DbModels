namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuIdentitylink
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string GroupId { get; set; }

    public string Type { get; set; }

    public string UserId { get; set; }

    public string TaskId { get; set; }

    public string ProcDefId { get; set; }

    public string TenantId { get; set; }

    public virtual ActReProcdef ProcDef { get; set; }

    public virtual ActRuTask Task { get; set; }
}
