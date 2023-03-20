namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_execution
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? root_proc_inst_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? business_key_ { get; set; }

    public string? parent_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? super_exec_ { get; set; }

    public string? super_case_exec_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? act_id_ { get; set; }

    public string? act_inst_id_ { get; set; }

    public bool? is_active_ { get; set; }

    public bool? is_concurrent_ { get; set; }

    public bool? is_scope_ { get; set; }

    public bool? is_event_scope_ { get; set; }

    public int? suspension_state_ { get; set; }

    public int? cached_ent_state_ { get; set; }

    public long? sequence_counter_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual ICollection<act_ru_execution> Inverseparent_id_Navigation { get; } = new List<act_ru_execution>();

    public virtual ICollection<act_ru_execution> Inverseproc_inst_id_Navigation { get; } = new List<act_ru_execution>();

    public virtual ICollection<act_ru_execution> Inversesuper_exec_Navigation { get; } = new List<act_ru_execution>();

    public virtual ICollection<act_ru_event_subscr> act_ru_event_subscrs { get; } = new List<act_ru_event_subscr>();

    public virtual ICollection<act_ru_ext_task> act_ru_ext_tasks { get; } = new List<act_ru_ext_task>();

    public virtual ICollection<act_ru_incident> act_ru_incidentexecution_id_Navigations { get; } = new List<act_ru_incident>();

    public virtual ICollection<act_ru_incident> act_ru_incidentproc_inst_id_Navigations { get; } = new List<act_ru_incident>();

    public virtual ICollection<act_ru_task> act_ru_taskexecution_id_Navigations { get; } = new List<act_ru_task>();

    public virtual ICollection<act_ru_task> act_ru_taskproc_inst_id_Navigations { get; } = new List<act_ru_task>();

    public virtual ICollection<act_ru_variable> act_ru_variableexecution_id_Navigations { get; } = new List<act_ru_variable>();

    public virtual ICollection<act_ru_variable> act_ru_variableproc_inst_id_Navigations { get; } = new List<act_ru_variable>();

    public virtual act_ru_execution? parent_id_Navigation { get; set; }

    public virtual act_re_procdef? proc_def_id_Navigation { get; set; }

    public virtual act_ru_execution? proc_inst_id_Navigation { get; set; }

    public virtual act_ru_execution? super_exec_Navigation { get; set; }
}
