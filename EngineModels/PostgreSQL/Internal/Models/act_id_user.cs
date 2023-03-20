namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_id_user
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? first_ { get; set; }

    public string? last_ { get; set; }

    public string? email_ { get; set; }

    public string? pwd_ { get; set; }

    public string? salt_ { get; set; }

    public DateTime? lock_exp_time_ { get; set; }

    public int? attempts_ { get; set; }

    public string? picture_id_ { get; set; }

    public virtual ICollection<act_id_tenant_member> act_id_tenant_members { get; } = new List<act_id_tenant_member>();

    public virtual ICollection<act_id_group> group_id_s { get; } = new List<act_id_group>();
}
