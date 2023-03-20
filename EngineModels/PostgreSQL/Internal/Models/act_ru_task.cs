using WF.Engine.DbModels.EngineModels.ExtendFields;

namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_task : RuTask
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? proc_def_id_ { get; set; }

    public string? case_execution_id_ { get; set; }

    public string? case_inst_id_ { get; set; }

    public string? case_def_id_ { get; set; }

    public string? name_ { get; set; }

    public string? parent_task_id_ { get; set; }

    public string? description_ { get; set; }

    public string? task_def_key_ { get; set; }

    public string? owner_ { get; set; }

    public string? assignee_ { get; set; }

    public string? delegation_ { get; set; }

    public int? priority_ { get; set; }

    public DateTime? create_time_ { get; set; }

    public DateTime? due_date_ { get; set; }

    public DateTime? follow_up_date_ { get; set; }

    public int? suspension_state_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual ICollection<act_ru_identitylink> act_ru_identitylinks { get; } = new List<act_ru_identitylink>();

    public virtual act_re_case_def? case_def_id_Navigation { get; set; }

    public virtual act_ru_case_execution? case_execution_id_Navigation { get; set; }

    public virtual act_ru_execution? execution_id_Navigation { get; set; }

    public virtual act_re_procdef? proc_def_id_Navigation { get; set; }

    public virtual act_ru_execution? proc_inst_id_Navigation { get; set; }
}
