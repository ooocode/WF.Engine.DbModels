namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_jobdef
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? act_id_ { get; set; }

    public string job_type_ { get; set; } = null!;

    public string? job_configuration_ { get; set; }

    public int? suspension_state_ { get; set; }

    public long? job_priority_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? deployment_id_ { get; set; }

    public virtual ICollection<act_ru_batch> act_ru_batchbatch_job_def_id_Navigations { get; } = new List<act_ru_batch>();

    public virtual ICollection<act_ru_batch> act_ru_batchmonitor_job_def_id_Navigations { get; } = new List<act_ru_batch>();

    public virtual ICollection<act_ru_batch> act_ru_batchseed_job_def_id_Navigations { get; } = new List<act_ru_batch>();

    public virtual ICollection<act_ru_incident> act_ru_incidents { get; } = new List<act_ru_incident>();
}
