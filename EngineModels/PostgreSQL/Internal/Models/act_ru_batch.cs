namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_batch
{
    public string id_ { get; set; } = null!;

    public int rev_ { get; set; }

    public string? type_ { get; set; }

    public int? total_jobs_ { get; set; }

    public int? jobs_created_ { get; set; }

    public int? jobs_per_seed_ { get; set; }

    public int? invocations_per_job_ { get; set; }

    public string? seed_job_def_id_ { get; set; }

    public string? batch_job_def_id_ { get; set; }

    public string? monitor_job_def_id_ { get; set; }

    public int? suspension_state_ { get; set; }

    public string? configuration_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? create_user_id_ { get; set; }

    public virtual ICollection<act_ru_variable> act_ru_variables { get; } = new List<act_ru_variable>();

    public virtual act_ru_jobdef? batch_job_def_id_Navigation { get; set; }

    public virtual act_ru_jobdef? monitor_job_def_id_Navigation { get; set; }

    public virtual act_ru_jobdef? seed_job_def_id_Navigation { get; set; }
}
