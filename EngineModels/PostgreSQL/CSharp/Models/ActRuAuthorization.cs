namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActRuAuthorization
{
    public string Id { get; set; } = null!;

    public int Rev { get; set; }

    public int Type { get; set; }

    public string GroupId { get; set; }

    public string UserId { get; set; }

    public int ResourceType { get; set; }

    public string ResourceId { get; set; }

    public int? Perms { get; set; }

    public DateTime? RemovalTime { get; set; }

    public string RootProcInstId { get; set; }
}
