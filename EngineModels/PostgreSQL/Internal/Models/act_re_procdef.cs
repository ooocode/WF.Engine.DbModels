namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_re_procdef
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? category_ { get; set; }

    public string? name_ { get; set; }

    public string key_ { get; set; } = null!;

    public int version_ { get; set; }

    public string? deployment_id_ { get; set; }

    public string? resource_name_ { get; set; }

    public string? dgrm_resource_name_ { get; set; }

    public bool? has_start_form_key_ { get; set; }

    public int? suspension_state_ { get; set; }

    public string? tenant_id_ { get; set; }

    public string? version_tag_ { get; set; }

    public int? history_ttl_ { get; set; }

    public bool? startable_ { get; set; }

    public virtual ICollection<act_ru_execution> act_ru_executions { get; } = new List<act_ru_execution>();

    public virtual ICollection<act_ru_identitylink> act_ru_identitylinks { get; } = new List<act_ru_identitylink>();

    public virtual ICollection<act_ru_incident> act_ru_incidents { get; } = new List<act_ru_incident>();

    public virtual ICollection<act_ru_task> act_ru_tasks { get; } = new List<act_ru_task>();
}
