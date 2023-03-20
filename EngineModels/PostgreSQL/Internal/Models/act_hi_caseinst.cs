namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_caseinst
{
    public string id_ { get; set; } = null!;

    public string case_inst_id_ { get; set; } = null!;

    public string? business_key_ { get; set; }

    public string case_def_id_ { get; set; } = null!;

    public DateTime create_time_ { get; set; }

    public DateTime? close_time_ { get; set; }

    public long? duration_ { get; set; }

    public int? state_ { get; set; }

    public string? create_user_id_ { get; set; }

    public string? super_case_instance_id_ { get; set; }

    public string? super_process_instance_id_ { get; set; }

    public string? tenant_id_ { get; set; }
}
