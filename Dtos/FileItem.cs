namespace WF.Engine.DbModels.Dtos
{
    public class FileItem
    {
        public string OrignFileName { get; set; }
        public string FileName { get; set; }
        public long BytesLength { get; set; }

        public string Tag { get; set; }

        public int Order { get; set; }

        public bool? NotAllowedDelete { get; set; }
        public bool? Hidden { get; set; }


    }
}
