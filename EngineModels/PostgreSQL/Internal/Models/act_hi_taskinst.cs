namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_taskinst
{
    public string id_ { get; set; } = null!;

    public string? task_def_key_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? case_def_key_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? case_execution_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public string? name_ { get; set; }

    public string? parent_task_id_ { get; set; }

    public string? description_ { get; set; }

    public string? owner_ { get; set; }

    public string? assignee_ { get; set; }

    public DateTime start_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public long? duration_ { get; set; }

    public string? delete_reason_ { get; set; }

    public int? priority_ { get; set; }

    public DateTime? due_date_ { get; set; }

    public DateTime? follow_up_date_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
