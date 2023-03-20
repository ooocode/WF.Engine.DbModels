namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActIdTenantMember
{
    public string Id { get; set; } = null!;

    public string TenantId { get; set; } = null!;

    public string UserId { get; set; }

    public string GroupId { get; set; }

    public virtual ActIdGroup Group { get; set; }

    public virtual ActIdTenant Tenant { get; set; } = null!;

    public virtual ActIdUser User { get; set; }
}
