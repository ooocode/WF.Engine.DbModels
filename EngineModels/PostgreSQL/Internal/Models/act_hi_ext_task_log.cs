namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_ext_task_log
{
    public string id_ { get; set; } = null!;

    public DateTime timestamp_ { get; set; }

    public string ext_task_id_ { get; set; } = null!;

    public int? retries_ { get; set; }

    public string? topic_name_ { get; set; }

    public string? worker_id_ { get; set; }

    public long priority_ { get; set; }

    public string? error_msg_ { get; set; }

    public string? error_details_id_ { get; set; }

    public string? act_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? tenant_id_ { get; set; }

    public int? state_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
