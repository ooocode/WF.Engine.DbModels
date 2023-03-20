namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ge_bytearray
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? name_ { get; set; }

    public string? deployment_id_ { get; set; }

    public byte[]? bytes_ { get; set; }

    public bool? generated_ { get; set; }

    public string? tenant_id_ { get; set; }

    public int? type_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }

    public virtual ICollection<act_ru_ext_task> act_ru_ext_tasks { get; } = new List<act_ru_ext_task>();

    public virtual ICollection<act_ru_job> act_ru_jobs { get; } = new List<act_ru_job>();

    public virtual ICollection<act_ru_variable> act_ru_variables { get; } = new List<act_ru_variable>();

    public virtual act_re_deployment? deployment_id_Navigation { get; set; }
}
