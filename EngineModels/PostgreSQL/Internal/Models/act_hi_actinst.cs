namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_actinst
{
    public string id_ { get; set; } = null!;

    public string? parent_act_inst_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string proc_def_id_ { get; set; } = null!;

    public string? root_proc_inst_id_ { get; set; }

    public string proc_inst_id_ { get; set; } = null!;

    public string execution_id_ { get; set; } = null!;

    public string act_id_ { get; set; } = null!;

    public string? task_id_ { get; set; }

    public string? call_proc_inst_id_ { get; set; }

    public string? call_case_inst_id_ { get; set; }

    public string? act_name_ { get; set; }

    public string act_type_ { get; set; } = null!;

    public string? assignee_ { get; set; }

    public DateTime start_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public long? duration_ { get; set; }

    public int? act_inst_state_ { get; set; }

    public long? sequence_counter_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
