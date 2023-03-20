namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_batch
{
    public string id_ { get; set; } = null!;

    public string? type_ { get; set; }

    public int? total_jobs_ { get; set; }

    public int? jobs_per_seed_ { get; set; }

    public int? invocations_per_job_ { get; set; }

    public string? seed_job_def_id_ { get; set; }

    public string? monitor_job_def_id_ { get; set; }

    public string? batch_job_def_id_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? create_user_id_ { get; set; }

    public DateTime start_time_ { get; set; }

    public DateTime? end_time_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
