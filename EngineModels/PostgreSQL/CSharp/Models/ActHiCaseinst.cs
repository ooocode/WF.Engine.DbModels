namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiCaseinst
{
    public string Id { get; set; } = null!;

    public string CaseInstId { get; set; } = null!;

    public string BusinessKey { get; set; }

    public string CaseDefId { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? CloseTime { get; set; }

    public long? Duration { get; set; }

    public int? State { get; set; }

    public string CreateUserId { get; set; }

    public string SuperCaseInstanceId { get; set; }

    public string SuperProcessInstanceId { get; set; }

    public string TenantId { get; set; }
}
