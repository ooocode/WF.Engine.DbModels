namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

public partial class ActHiDecinst
{
    public string Id { get; set; } = null!;

    public string DecDefId { get; set; } = null!;

    public string DecDefKey { get; set; } = null!;

    public string DecDefName { get; set; }

    public string ProcDefKey { get; set; }

    public string ProcDefId { get; set; }

    public string ProcInstId { get; set; }

    public string CaseDefKey { get; set; }

    public string CaseDefId { get; set; }

    public string CaseInstId { get; set; }

    public string ActInstId { get; set; }

    public string ActId { get; set; }

    public DateTime EvalTime { get; set; }

    public DateTime? RemovalTime { get; set; }

    public double? CollectValue { get; set; }

    public string UserId { get; set; }

    public string RootDecInstId { get; set; }

    public string RootProcInstId { get; set; }

    public string DecReqId { get; set; }

    public string DecReqKey { get; set; }

    public string TenantId { get; set; }
}
