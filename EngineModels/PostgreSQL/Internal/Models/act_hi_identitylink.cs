namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_identitylink
{
    public string id_ { get; set; } = null!;

    public DateTime timestamp_ { get; set; }

    public string? type_ { get; set; }

    public string? user_id_ { get; set; }

    public string? group_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? operation_type_ { get; set; }

    public string? assigner_id_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
