namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_op_log
{
    public string id_ { get; set; } = null!;

    public string? deployment_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? case_execution_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string? job_id_ { get; set; }

    public string? job_def_id_ { get; set; }

    public string? batch_id_ { get; set; }

    public string? user_id_ { get; set; }

    public DateTime timestamp_ { get; set; }

    public string? operation_type_ { get; set; }

    public string? operation_id_ { get; set; }

    public string? entity_type_ { get; set; }

    public string? property_ { get; set; }

    public string? org_value_ { get; set; }

    public string? new_value_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }

    public string? category_ { get; set; }

    public string? external_task_id_ { get; set; }

    public string? annotation_ { get; set; }
}
