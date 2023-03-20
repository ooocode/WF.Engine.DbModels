namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_job_log
{
    public string id_ { get; set; } = null!;

    public DateTime timestamp_ { get; set; }

    public string job_id_ { get; set; } = null!;

    public DateTime? job_duedate_ { get; set; }

    public int? job_retries_ { get; set; }

    public long job_priority_ { get; set; }

    public string? job_exception_msg_ { get; set; }

    public string? job_exception_stack_id_ { get; set; }

    public int? job_state_ { get; set; }

    public string? job_def_id_ { get; set; }

    public string? job_def_type_ { get; set; }

    public string? job_def_configuration_ { get; set; }

    public string? act_id_ { get; set; }

    public string? failed_act_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? process_instance_id_ { get; set; }

    public string? process_def_id_ { get; set; }

    public string? process_def_key_ { get; set; }

    public string? deployment_id_ { get; set; }

    public long? sequence_counter_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? hostname_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
