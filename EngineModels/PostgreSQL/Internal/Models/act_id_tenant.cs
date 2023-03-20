namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_id_tenant
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? name_ { get; set; }

    public virtual ICollection<act_id_tenant_member> act_id_tenant_members { get; } = new List<act_id_tenant_member>();
}
