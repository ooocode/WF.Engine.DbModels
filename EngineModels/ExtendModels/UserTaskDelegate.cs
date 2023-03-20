#nullable disable


namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public partial class UserTaskDelegate
    {
        public string Id { get; set; }

        public string FromUserName { get; set; }
        public string ToUserName { get; set; }
        public bool IsCopySendToSource { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
    }
}
