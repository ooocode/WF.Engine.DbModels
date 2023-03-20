namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActGeSchemaLog
{
    public string Id { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string Version { get; set; }
}
