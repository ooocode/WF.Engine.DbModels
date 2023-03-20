namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_id_tenant_member
{
    public string id_ { get; set; } = null!;

    public string tenant_id_ { get; set; } = null!;

    public string? user_id_ { get; set; }

    public string? group_id_ { get; set; }

    public virtual act_id_group? group_id_Navigation { get; set; }

    public virtual act_id_tenant tenant_id_Navigation { get; set; } = null!;

    public virtual act_id_user? user_id_Navigation { get; set; }
}
