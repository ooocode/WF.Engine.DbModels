namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiAttachment
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string UserId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Type { get; set; }

    public string TaskId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string Url { get; set; }

    public string ContentId { get; set; }

    public string TenantId { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? RemovalTime { get; set; }
}
