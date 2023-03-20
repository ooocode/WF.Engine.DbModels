namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_re_decision_def
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? category_ { get; set; }

    public string? name_ { get; set; }

    public string key_ { get; set; } = null!;

    public int version_ { get; set; }

    public string? deployment_id_ { get; set; }

    public string? resource_name_ { get; set; }

    public string? dgrm_resource_name_ { get; set; }

    public string? dec_req_id_ { get; set; }

    public string? dec_req_key_ { get; set; }

    public string? tenant_id_ { get; set; }

    public int? history_ttl_ { get; set; }

    public string? version_tag_ { get; set; }

    public virtual act_re_decision_req_def? dec_req_id_Navigation { get; set; }
}
