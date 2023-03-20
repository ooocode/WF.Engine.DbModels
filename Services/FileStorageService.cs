using Microsoft.Extensions.Options;
using WF.Engine.DbModels.Options;

namespace WF.Engine.DbModels.Services
{
    /// <summary>
    /// 文件存储服务
    /// </summary>
    public class FileStorageService
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly FileStorageOption fileStorageOption;

        public FileStorageService(IHttpClientFactory httpClientFactory, IOptions<FileStorageOption> options)
        {
            this.httpClientFactory = httpClientFactory;
            fileStorageOption = options.Value;

            //#if DEBUG
            //            fileStorageOption = new FileStorageOption
            //            {
            //                StorageMode = StorageMode.FileSystem,
            //                BasePath = "C:\\TEMP_OA_FILES"
            //            };
            //#endif
        }


        const string RootDirectoryName = "NewFiles";

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Stream> DownloadFileAsync(string id,
            CancellationToken cancellationToken)
        {
            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                var savePath = Path.Combine(fileStorageOption.BasePath, id);
                return File.OpenRead(savePath);
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                var httpClient = GetHttpClient();

                var year = id.Substring(0, 4);
                var month = id.Substring(4, 2);
                var day = id.Substring(6, 2);

                var uri = $"{RootDirectoryName}/{year}/{month}/{day}/{id}";
                var res = await httpClient.GetAsync(uri,
                    HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken);
                res.EnsureSuccessStatusCode();
                return await res.Content.ReadAsStreamAsync(cancellationToken);
            }
            else
            {
                throw new NotImplementedException("StorageMode 只能是0或1  0==物理文件  1==webdav");
            }
        }


        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<byte[]> DownloadFileAsBytesAsync(string id,
            CancellationToken cancellationToken)
        {
            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                var savePath = Path.Combine(fileStorageOption.BasePath, id);
                return await File.ReadAllBytesAsync(savePath, cancellationToken);
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                var httpClient = GetHttpClient();

                var year = id.Substring(0, 4);
                var month = id.Substring(4, 2);
                var day = id.Substring(6, 2);

                var uri = $"{RootDirectoryName}/{year}/{month}/{day}/{id}";
                var res = await httpClient.GetAsync(uri,
                    HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken);
                res.EnsureSuccessStatusCode();
                return await res.Content.ReadAsByteArrayAsync(cancellationToken);
            }
            else
            {
                throw new NotImplementedException("StorageMode 只能是0或1  0==物理文件  1==webdav");
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="nativeFileName">本地文件全路径</param>
        /// <param name="fileName">文件名，如果不指定，则自动生成随机文件名</param>
        /// <returns>返回文件id</returns>
        public async Task<string> UploadFileAsync(string nativeFileName, string fileName = null)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = $"{DateTimeOffset.Now.ToString("yyyyMMddHHmmss")}{Guid.NewGuid().ToString("N")}{Path.GetExtension(nativeFileName)}";
            }

            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                if (!Directory.Exists(fileStorageOption.BasePath))
                {
                    Directory.CreateDirectory(fileStorageOption.BasePath);
                }
                var savePath = Path.Combine(fileStorageOption.BasePath, fileName);
                File.Copy(nativeFileName, savePath, true);
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                HttpClient httpClient = GetHttpClient();
                using (var stream = File.OpenRead(nativeFileName))
                {
                    var year = fileName.Substring(0, 4);
                    var month = fileName.Substring(4, 2);
                    var day = fileName.Substring(6, 2);

                    var res = await httpClient.PutAsync($"{RootDirectoryName}/{year}/{month}/{day}/{fileName}", new StreamContent(stream));
                    res.EnsureSuccessStatusCode();
                }
            }

            return fileName;
        }


        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="nativeFileName">本地文件全路径</param>
        /// <param name="fileName">文件名，如果不指定，则自动生成随机文件名</param>
        /// <returns>返回文件id</returns>
        public async Task<string> UploadFileAsync(string nativeFileName, DateTimeOffset? createDateTime)
        {
            if (!createDateTime.HasValue)
            {
                createDateTime = DateTimeOffset.UtcNow;
            }

            var fileName = $"{createDateTime?.ToString("yyyyMMddHHmmss")}{Guid.NewGuid().ToString("N")}{Path.GetExtension(nativeFileName)}";

            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                if (!Directory.Exists(fileStorageOption.BasePath))
                {
                    Directory.CreateDirectory(fileStorageOption.BasePath);
                }
                var savePath = Path.Combine(fileStorageOption.BasePath, fileName);
                File.Copy(nativeFileName, savePath, true);
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                HttpClient httpClient = GetHttpClient();
                using (var stream = File.OpenRead(nativeFileName))
                {
                    var year = fileName.Substring(0, 4);
                    var month = fileName.Substring(4, 2);
                    var day = fileName.Substring(6, 2);

                    var res = await httpClient.PutAsync($"{RootDirectoryName}/{year}/{month}/{day}/{fileName}", new StreamContent(stream));
                    res.EnsureSuccessStatusCode();
                }
            }

            return fileName;
        }



        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteFileAsync(string id)
        {
            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                var path = Path.Combine(fileStorageOption.BasePath, id);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                var httpClient = GetHttpClient();

                var year = id.Substring(0, 4);
                var month = id.Substring(4, 2);
                var day = id.Substring(6, 2);

                var uri = $"{RootDirectoryName}/{year}/{month}/{day}/{id}";
                var res = await httpClient.DeleteAsync(uri);
                res.EnsureSuccessStatusCode();
            }
        }



        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> FileExistAsync(string id)
        {
            if (fileStorageOption.StorageMode == StorageMode.FileSystem)
            {
                var path = Path.Combine(fileStorageOption.BasePath, id);
                return File.Exists(path);
            }
            else if (fileStorageOption.StorageMode == StorageMode.WebDAV)
            {
                var httpClient = GetHttpClient();

                var year = id.Substring(0, 4);
                var month = id.Substring(4, 2);
                var day = id.Substring(6, 2);

                var uri = $"{RootDirectoryName}/{year}/{month}/{day}/{id}";

                var res = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
                return res.IsSuccessStatusCode;
            }

            return false;
        }

        private HttpClient GetHttpClient()
        {
            HttpClient httpClient = httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri(fileStorageOption.BasePath);
            string userName = fileStorageOption.UserName;
            string password = fileStorageOption.Password;
            string token = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{userName}:{password}"));
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", token);
            return httpClient;
        }
    }
}
