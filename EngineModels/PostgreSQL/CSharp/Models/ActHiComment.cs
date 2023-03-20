namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiComment
{
    public string Id { get; set; } = null!;

    public string Type { get; set; }

    public DateTime Time { get; set; }

    public string UserId { get; set; }

    public string TaskId { get; set; }

    public string RootProcInstId { get; set; }

    public string ProcInstId { get; set; }

    public string Action { get; set; }

    public string Message { get; set; }

    public byte[] FullMsg { get; set; }

    public string TenantId { get; set; }

    public DateTime? RemovalTime { get; set; }
}
