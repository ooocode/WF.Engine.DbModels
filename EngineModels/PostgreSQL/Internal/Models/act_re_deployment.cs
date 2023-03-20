namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_re_deployment
{
    public string id_ { get; set; } = null!;

    public string? name_ { get; set; }

    public DateTime? deploy_time_ { get; set; }

    public string? source_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual ICollection<act_ge_bytearray> act_ge_bytearrays { get; } = new List<act_ge_bytearray>();
}
