namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_incident
{
    public string id_ { get; set; } = null!;

    public string? proc_def_key_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public DateTime create_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public string? incident_msg_ { get; set; }

    public string incident_type_ { get; set; } = null!;

    public string? activity_id_ { get; set; }

    public string? failed_activity_id_ { get; set; }

    public string? cause_incident_id_ { get; set; }

    public string? root_cause_incident_id_ { get; set; }

    public string? configuration_ { get; set; }

    public string? history_configuration_ { get; set; }

    public int? incident_state_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? job_def_id_ { get; set; }

    public string? annotation_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
