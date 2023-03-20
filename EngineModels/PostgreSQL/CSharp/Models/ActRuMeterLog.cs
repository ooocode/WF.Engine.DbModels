namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuMeterLog
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Reporter { get; set; }

    public long? Value { get; set; }

    public DateTime? Timestamp { get; set; }

    public long? Milliseconds { get; set; }
}
