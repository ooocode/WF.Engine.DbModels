namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActIdGroup
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public virtual ICollection<ActIdTenantMember> ActIdTenantMembers { get; } = new List<ActIdTenantMember>();

    public virtual ICollection<ActIdUser> Users { get; } = new List<ActIdUser>();
}
