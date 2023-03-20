namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_case_sentry_part
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? case_exec_id_ { get; set; }

    public string? sentry_id_ { get; set; }

    public string? type_ { get; set; }

    public string? source_case_exec_id_ { get; set; }

    public string? standard_event_ { get; set; }

    public string? source_ { get; set; }

    public string? variable_event_ { get; set; }

    public string? variable_name_ { get; set; }

    public bool? satisfied_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual act_ru_case_execution? case_exec_id_Navigation { get; set; }

    public virtual act_ru_case_execution? case_inst_id_Navigation { get; set; }
}
