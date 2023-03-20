namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_re_case_def
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

    public string? tenant_id_ { get; set; }

    public int? history_ttl_ { get; set; }

    public virtual ICollection<act_ru_case_execution> act_ru_case_executions { get; } = new List<act_ru_case_execution>();

    public virtual ICollection<act_ru_task> act_ru_tasks { get; } = new List<act_ru_task>();
}
