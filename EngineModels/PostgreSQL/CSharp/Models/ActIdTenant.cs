namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActIdTenant
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Name { get; set; }

    public virtual ICollection<ActIdTenantMember> ActIdTenantMembers { get; } = new List<ActIdTenantMember>();
}
