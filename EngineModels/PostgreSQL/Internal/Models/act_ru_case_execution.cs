namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_case_execution
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? super_case_exec_ { get; set; }

    public string? super_exec_ { get; set; }

    public string? business_key_ { get; set; }

    public string? parent_id_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? act_id_ { get; set; }

    public int? prev_state_ { get; set; }

    public int? current_state_ { get; set; }

    public bool? required_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual ICollection<act_ru_case_execution> Inversecase_inst_id_Navigation { get; } = new List<act_ru_case_execution>();

    public virtual ICollection<act_ru_case_execution> Inverseparent_id_Navigation { get; } = new List<act_ru_case_execution>();

    public virtual ICollection<act_ru_case_sentry_part> act_ru_case_sentry_partcase_exec_id_Navigations { get; } = new List<act_ru_case_sentry_part>();

    public virtual ICollection<act_ru_case_sentry_part> act_ru_case_sentry_partcase_inst_id_Navigations { get; } = new List<act_ru_case_sentry_part>();

    public virtual ICollection<act_ru_task> act_ru_tasks { get; } = new List<act_ru_task>();

    public virtual ICollection<act_ru_variable> act_ru_variablecase_execution_id_Navigations { get; } = new List<act_ru_variable>();

    public virtual ICollection<act_ru_variable> act_ru_variablecase_inst_id_Navigations { get; } = new List<act_ru_variable>();

    public virtual act_re_case_def? case_def_id_Navigation { get; set; }

    public virtual act_ru_case_execution? case_inst_id_Navigation { get; set; }

    public virtual act_ru_case_execution? parent_id_Navigation { get; set; }
}
