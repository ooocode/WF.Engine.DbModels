namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_procinst
{
    public string id_ { get; set; } = null!;

    public string proc_inst_id_ { get; set; } = null!;

    public string? business_key_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string proc_def_id_ { get; set; } = null!;

    public DateTime start_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public DateTime? removal_time_ { get; set; }

    public long? duration_ { get; set; }

    public string? start_user_id_ { get; set; }

    public string? start_act_id_ { get; set; }

    public string? end_act_id_ { get; set; }

    public string? super_process_instance_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? super_case_instance_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? delete_reason_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? state_ { get; set; }
}
