namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiIncident
{
    public string Id { get; set; } = null!;

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string ExecutionId { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string IncidentMsg { get; set; }

    public string IncidentType { get; set; } = null!;

    public string ActivityId { get; set; }

    public string FailedActivityId { get; set; }

    public string CauseIncidentId { get; set; }

    public string RootCauseIncidentId { get; set; }

    public string Configuration { get; set; }

    public string HistoryConfiguration { get; set; }

    public int? IncidentState { get; set; }

    public string TenantId { get; set; }

    public string JobDefId { get; set; }

    public string Annotation { get; set; }

    public DateTime? RemovalTime { get; set; }
}
