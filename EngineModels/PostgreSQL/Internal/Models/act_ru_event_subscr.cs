namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_event_subscr
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string event_type_ { get; set; } = null!;

    public string? event_name_ { get; set; }

    public string? execution_id_ { get; set; }

    public string? proc_inst_id_ { get; set; }

    public string? activity_id_ { get; set; }

    public string? configuration_ { get; set; }

    public DateTime created_ { get; set; }

    public string? tenant_id_ { get; set; }

    public virtual act_ru_execution? execution_id_Navigation { get; set; }
}
