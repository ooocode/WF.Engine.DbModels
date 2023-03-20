namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

public partial class act_ru_meter_log
{
    public string id_ { get; set; } = null!;

    public string name_ { get; set; } = null!;

    public string? reporter_ { get; set; }

    public long? value_ { get; set; }

    public DateTime? timestamp_ { get; set; }

    public long? milliseconds_ { get; set; }
}
