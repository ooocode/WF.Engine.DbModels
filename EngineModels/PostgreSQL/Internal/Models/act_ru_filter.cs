namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_filter
{
    public string id_ { get; set; } = null!;

    public int rev_ { get; set; }

    public string resource_type_ { get; set; } = null!;

    public string name_ { get; set; } = null!;

    public string? owner_ { get; set; }

    public string query_ { get; set; } = null!;

    public string? properties_ { get; set; }
}
