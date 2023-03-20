namespace WF.Engine.DbModels.Dtos
{
    public class User
    {
        //#if NET7_0
        //        public required string UserName { get; set; }
        //        public required string UserDisplayName { get; set; }
        //        public required string DepartmentDisplayName { get; set; }
        //#else
        public string UserName { get; set; }
        public string UserDisplayName { get; set; }
        public string DepartmentDisplayName { get; set; }
    }
}
