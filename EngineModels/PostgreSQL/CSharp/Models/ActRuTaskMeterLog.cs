namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuTaskMeterLog
{
    public string Id { get; set; } = null!;

    public long? AssigneeHash { get; set; }

    public DateTime? Timestamp { get; set; }
}
