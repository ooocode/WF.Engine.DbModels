namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiDecOut
{
    public string Id { get; set; } = null!;

    public string DecInstId { get; set; } = null!;

    public string ClauseId { get; set; }

    public string ClauseName { get; set; }

    public string RuleId { get; set; }

    public int? RuleOrder { get; set; }

    public string VarName { get; set; }

    public string VarType { get; set; }

    public string BytearrayId { get; set; }

    public double? Double { get; set; }

    public long? Long { get; set; }

    public string Text { get; set; }

    public string Text2 { get; set; }

    public string TenantId { get; set; }

    public DateTime? CreateTime { get; set; }

    public string RootProcInstId { get; set; }

    public DateTime? RemovalTime { get; set; }
}
