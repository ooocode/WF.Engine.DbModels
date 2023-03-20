namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_caseactinst
{
    public string id_ { get; set; } = null!;

    public string? parent_act_inst_id_ { get; set; }

    public string case_def_id_ { get; set; } = null!;

    public string case_inst_id_ { get; set; } = null!;

    public string case_act_id_ { get; set; } = null!;

    public string? task_id_ { get; set; }

    public string? call_proc_inst_id_ { get; set; }

    public string? call_case_inst_id_ { get; set; }

    public string? case_act_name_ { get; set; }

    public string? case_act_type_ { get; set; }

    public DateTime create_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public long? duration_ { get; set; }

    public int? state_ { get; set; }

    public bool? required_ { get; set; }

    public string? tenant_id_ { get; set; }
}
