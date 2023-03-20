namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActReDeployment
{
    public string Id { get; set; } = null!;

    public string Name { get; set; }

    public DateTime? DeployTime { get; set; }

    public string Source { get; set; }

    public string TenantId { get; set; }

    public virtual ICollection<ActGeBytearray> ActGeBytearrays { get; } = new List<ActGeBytearray>();
}
