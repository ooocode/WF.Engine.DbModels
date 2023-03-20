namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_ext_task
{
    public string id_ { get; set; } = null!;

    public int rev_ { get; set; }

    public string? worker_id_ { get; set; }

    public string? topic_name_ { get; set; }

    public int? retries_ { get; set; }

    public string? error_msg_ { get; set; }

    public string? error_details_id_ { get; set; }

    public DateTime? lock_exp_time_ { get; set; }

    public int? suspension_state_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? act_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public string? tenant_id_ { get; set; }

    public long priority_ { get; set; }

    public string? last_failure_log_id_ { get; set; }

    public virtual act_ge_bytearray? error_details_id_Navigation { get; set; }

    public virtual act_ru_execution? execution_id_Navigation { get; set; }
}
