namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_id_info
{
    public string id_ { get; set; } = null!;

    public int? rev_ { get; set; }

    public string? user_id_ { get; set; }

    public string? type_ { get; set; }

    public string? key_ { get; set; }

    public string? value_ { get; set; }

    public byte[]? password_ { get; set; }

    public string? parent_id_ { get; set; }
}
