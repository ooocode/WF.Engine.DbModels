namespace WF.Engine.DbModels.Options
{
    public class FileStorageOption
    {
        public const string Key = "FileStorageOption";

        /// <summary>
        /// 存储模式
        /// </summary>
        public StorageMode StorageMode { get; set; }

        /// <summary>
        /// 存储基本路径，可以是Webdav的http或者本地文件系统
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// 用户名，共享文件夹或者webdav需要验证时用到
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码，共享文件夹或者webdav需要验证时用到
        /// </summary>
        public string Password { get; set; }

    }

    public enum StorageMode
    {
        FileSystem,
        WebDAV
    }
}
