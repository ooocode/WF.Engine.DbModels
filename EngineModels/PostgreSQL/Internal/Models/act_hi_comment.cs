namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_comment
{
    public string id_ { get; set; } = null!;

    public string? type_ { get; set; }

    public DateTime time_ { get; set; }

    public string? user_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? action_ { get; set; }

    public string? message_ { get; set; }

    public byte[]? full_msg_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
