namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_identitylink
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? group_id_ { get; set; }

    public string? type_ { get; set; }

    public string? user_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual act_re_procdef? proc_def_id_Navigation { get; set; }

    public virtual act_ru_task? task_id_Navigation { get; set; }
}
