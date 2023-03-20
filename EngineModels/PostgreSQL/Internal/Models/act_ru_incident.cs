namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_incident
{
    public string id_ { get; set; } = null!;

    public int rev_ { get; set; }

    public DateTime incident_timestamp_ { get; set; }

    public string? incident_msg_ { get; set; }

    public string incident_type_ { get; set; } = null!;

    public string? execution_id_ { get; set; }

    public string? activity_id_ { get; set; }

    public string? failed_activity_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? cause_incident_id_ { get; set; }

    public string? root_cause_incident_id_ { get; set; }

    public string? configuration_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? job_def_id_ { get; set; }

    public string? annotation_ { get; set; }

    public virtual ICollection<act_ru_incident> Inversecause_incident_id_Navigation { get; } = new List<act_ru_incident>();

    public virtual ICollection<act_ru_incident> Inverseroot_cause_incident_id_Navigation { get; } = new List<act_ru_incident>();

    public virtual act_ru_incident? cause_incident_id_Navigation { get; set; }

    public virtual act_ru_execution? execution_id_Navigation { get; set; }

    public virtual act_ru_jobdef? job_def_id_Navigation { get; set; }

    public virtual act_re_procdef? proc_def_id_Navigation { get; set; }

    public virtual act_ru_execution? proc_inst_id_Navigation { get; set; }

    public virtual act_ru_incident? root_cause_incident_id_Navigation { get; set; }
}
