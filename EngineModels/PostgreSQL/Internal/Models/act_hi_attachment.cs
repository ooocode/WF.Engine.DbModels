namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_attachment
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? user_id_ { get; set; }

    public string? name_ { get; set; }

    public string? description_ { get; set; }

    public string? type_ { get; set; }

    public string? task_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? url_ { get; set; }

    public string? content_id_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
