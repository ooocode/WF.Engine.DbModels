namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_varinst
{
    public string id_ { get; set; } = null!;

    public string? proc_def_key_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public string? case_def_key_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? case_execution_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string name_ { get; set; } = null!;

    public string? var_type_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public int? rev_ { get; set; }

    public string? bytearray_id_ { get; set; }

    public double? double_ { get; set; }

    public long? long_ { get; set; }

    public string? text_ { get; set; }

    public string? text2_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? state_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
