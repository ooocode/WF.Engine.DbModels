namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_variable
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string type_ { get; set; } = null!;

    public string name_ { get; set; } = null!;

    public string? execution_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? case_execution_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? task_id_ { get; set; }

    public string? batch_id_ { get; set; }

    public string? bytearray_id_ { get; set; }

    public double? double_ { get; set; }

    public long? long_ { get; set; }

    public string? text_ { get; set; }

    public string? text2_ { get; set; }

    public string? var_scope_ { get; set; }

    public long? sequence_counter_ { get; set; }

    public bool? is_concurrent_local_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual act_ru_batch? batch_id_Navigation { get; set; }

    public virtual act_ge_bytearray? bytearray_id_Navigation { get; set; }

    public virtual act_ru_case_execution? case_execution_id_Navigation { get; set; }

    public virtual act_ru_case_execution? case_inst_id_Navigation { get; set; }

    public virtual act_ru_execution? execution_id_Navigation { get; set; }

    public virtual act_ru_execution? proc_inst_id_Navigation { get; set; }
}
