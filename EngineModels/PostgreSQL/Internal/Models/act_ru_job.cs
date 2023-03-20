namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_job
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string type_ { get; set; } = null!;

    public DateTime? lock_exp_time_ { get; set; }

    public string? lock_owner_ { get; set; }

    public bool? exclusive_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? process_instance_id_ { get; set; }

    public string? process_def_id_ { get; set; }

    public string? process_def_key_ { get; set; }

    public int? retries_ { get; set; }

    public string? exception_stack_id_ { get; set; }

    public string? exception_msg_ { get; set; }

    public string? failed_act_id_ { get; set; }

    public DateTime? duedate_ { get; set; }

    public string? repeat_ { get; set; }

    public long? repeat_offset_ { get; set; }

    public string? handler_type_ { get; set; }

    public string? handler_cfg_ { get; set; }

    public string? deployment_id_ { get; set; }

    public int suspension_state_ { get; set; }

    public string? job_def_id_ { get; set; }

    public long priority_ { get; set; }

    public long? sequence_counter_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public string? last_failure_log_id_ { get; set; }

    public virtual act_ge_bytearray? exception_stack_id_Navigation { get; set; }
}
