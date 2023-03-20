namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_dec_out
{
    public string id_ { get; set; } = null!;

    public string dec_inst_id_ { get; set; } = null!;

    public string? clause_id_ { get; set; }

    public string? clause_name_ { get; set; }

    public string? rule_id_ { get; set; }

    public int? rule_order_ { get; set; }

    public string? var_name_ { get; set; }

    public string? var_type_ { get; set; }

    public string? bytearray_id_ { get; set; }

    public double? double_ { get; set; }

    public long? long_ { get; set; }

    public string? text_ { get; set; }

    public string? text2_ { get; set; }

    public string? tenant_id_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public DateTime? removal_time_ { get; set; }
}
