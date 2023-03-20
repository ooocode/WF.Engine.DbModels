namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_authorization
{
    public string id_ { get; set; } = null!;

    public int rev_ { get; set; }

    public int type_ { get; set; }

    public string? group_id_ { get; set; }

    public string? user_id_ { get; set; }

    public int resource_type_ { get; set; }

    public string? resource_id_ { get; set; }

    public int? perms_ { get; set; }

    public DateTime? removal_time_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }
}
