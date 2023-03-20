namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_hi_decinst
{
    public string id_ { get; set; } = null!;

    public string dec_def_id_ { get; set; } = null!;

    public string dec_def_key_ { get; set; } = null!;

    public string? dec_def_name_ { get; set; }

    public string? proc_def_key_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? case_def_key_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public string? act_id_ { get; set; }

    public DateTime eval_time_ { get; set; }

    public DateTime? removal_time_ { get; set; }

    public double? collect_value_ { get; set; }

    public string? user_id_ { get; set; }

    public string? root_dec_inst_id_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? dec_req_id_ { get; set; }

    public string? dec_req_key_ { get; set; }

    public string? tenant_id_ { get; set; }
}
