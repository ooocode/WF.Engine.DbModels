namespace WF.Engine.DbModels.Dtos
{
    public class DisposeItem
    {
        public string DisposeVarName { get; set; }
        public string DisposeVarValue { get; set; }
        public string AssigneeVarName { get; set; }
        public string AssigneeVarValue { get; set; }
        public bool TargetActivityIsMultiInstance { get; set; }
        public string UserListVarName { get; set; }
    }
}
