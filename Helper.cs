using Engine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Quartz;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using WF.Engine.DbModels.Contract;
using WF.Engine.DbModels.EngineModels;
using WF.Engine.DbModels.Jobs;
using WF.Engine.DbModels.Services;

namespace WF.Engine.DbModels
{
    public static class Helper
    {
        public const int engineGprcPort = 9999;
        public const int engineWebPort = 5003;

        /// <summary>
        /// 添加引擎数据库和引擎客户端
        /// </summary>
        /// <param name="services"></param>
        /// <param name="engineDbConnectionString">数据库连接字符串</param>
        /// <param name="ensureCreated">自动创建数据</param>
        /// <param name="grpcServerUrl">Grpc引擎地址，如果为空，自动启动内置引擎</param>
        public static void AddEngineDbContextAndGrpcClient(
            this IServiceCollection services,
            string engineDbConnectionString,
            bool ensureCreated = false,
            string grpcServerUrl = null)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            AddEngineDbContext(services, engineDbConnectionString, ensureCreated);

            services.AddTransient<GprcClientInterceptor>();
            if (string.IsNullOrWhiteSpace(grpcServerUrl))
            {
                NpgsqlConnectionStringBuilder keyValuePairs = new NpgsqlConnectionStringBuilder(engineDbConnectionString);

                var lines = new StringBuilder();
                lines.AppendLine("server.address=0.0.0.0");
                lines.AppendLine($"server.port={engineWebPort}");
                lines.AppendLine($"grpc.server.port={engineGprcPort}");
                lines.AppendLine("camunda.bpm.eventing.execution=true");
                lines.AppendLine("camunda.bpm.eventing.history=true");
                lines.AppendLine("camunda.bpm.eventing.task=true");
                lines.AppendLine("camunda.bpm.admin-user.id=admin");
                lines.AppendLine("camunda.bpm.admin-user.password=admin");
                lines.AppendLine("spring.datasource.driver-class-name=org.postgresql.Driver");

                var javaConnectString = $"spring.datasource.url=jdbc:postgresql://{keyValuePairs.Host}:{keyValuePairs.Port}/{keyValuePairs.Database}?serverTimezone=UTC&createDatabaseIfNotExist=true&nullCatalogMeansCurrent=true&characterEncoding=utf8";
                lines.AppendLine(javaConnectString);
                lines.AppendLine($"spring.datasource.username={keyValuePairs.Username}");
                lines.AppendLine($"spring.datasource.password={keyValuePairs.Password}");
                lines.AppendLine("spring.datasource.hikari.maxLifetime=1");
                lines.AppendLine("spring.jpa.show-sql=false");
                lines.AppendLine("spring.jpa.properties.hibernate.format_sql=true");
                lines.AppendLine("spring.jpa.hibernate.ddl-auto=update");

                var dir = Path.Combine(AppContext.BaseDirectory, "JavaEngine", "config");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var fileName = Path.Combine(dir, "application.properties");
                File.WriteAllText(fileName, lines.ToString());

                Console.WriteLine($"{DateTimeOffset.UtcNow}:" +
                    $"使用内部Java引擎 [Grpc端口 {engineGprcPort}] " +
                    $"[Web端口 {engineWebPort}]");


                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = assembly
                    .GetManifestResourceNames()
                    .FirstOrDefault(e => e.EndsWith("engine-0.0.1-SNAPSHOT.jar"));

                using var stream = assembly.GetManifestResourceStream(resourceName);

                var jarFileName = Path.Combine(AppContext.BaseDirectory, "JavaEngine", "engine-0.0.1-SNAPSHOT.jar");
                using var fs = File.OpenWrite(jarFileName);
                stream.CopyTo(fs);
                fs.Close();
                stream.Close();

                ProcessStartInfo info = new ProcessStartInfo
                {
                    WorkingDirectory = $"{Path.Combine(AppContext.BaseDirectory, "JavaEngine")}",
                    FileName = "java",
                    UseShellExecute = false,
                    Arguments = $"-jar engine-0.0.1-SNAPSHOT.jar",
                };

                Process.Start(info);

                services.AddGrpcClient<ProcessService.ProcessServiceClient>(opt =>
                {
                    opt.Address = new Uri("http://127.0.0.1:9999");
                }).AddInterceptor<GprcClientInterceptor>();
            }
            else
            {
                services.AddGrpcClient<ProcessService.ProcessServiceClient>(opt =>
                {
                    opt.Address = new Uri(grpcServerUrl);
                }).AddInterceptor<GprcClientInterceptor>();
                Console.WriteLine($"{DateTimeOffset.UtcNow}:使用外部Java引擎[{grpcServerUrl}]");
            }
        }

        private static void AddEngineDbContext(this IServiceCollection services,
           string connectionString,
           bool ensureCreated = false)
        {
            if (ensureCreated)
            {
                using InternalEngineDbContext dbContext = new
                    InternalEngineDbContext(connectionString);
                var result = dbContext.Database.EnsureCreated();
                var now = DateTimeOffset.UtcNow;
                if (result)
                {
                    Console.WriteLine($"{now}: 创建引擎数据库成功");
                }
                else
                {
                    Console.WriteLine($"{now}: 引擎数据库成功");
                }
            }

            services.AddDbContextFactory<EngineDbContext>(opt =>
            {
                opt.UseNpgsql(connectionString);
            });
        }

        /// <summary>
        /// 添加文件存储服务
        /// </summary>
        /// <param name="services"></param>
        public static void AddFileStorageService(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<FileStorageService>();
        }

        public static void AddEngineUserTaskJobs(
            this IServiceCollection services,
            TimeSpan interval,
            bool enabled)
        {
            services.AddQuartz(q =>
            {
                // as of 3.3.2 this also injects scoped services (like EF DbContext) without problems
                q.UseMicrosoftDependencyInjectionJobFactory();
                if (enabled)
                {
                    q.AddJob<UserTaskEventJob>(new JobKey(UserTaskEventJob.JobKey))
                        .AddTrigger(t =>
                    {
                        t.StartNow().WithSimpleSchedule(x => x
                           .WithInterval(interval)
                           .RepeatForever())
                           .ForJob(new JobKey(UserTaskEventJob.JobKey));
                    });
                }

                // ASP.NET Core hosting
                services.AddQuartzServer(options =>
                {
                    // when shutting down we want jobs to complete gracefully
                    options.WaitForJobsToComplete = true;
                });
            });
        }

        public static void AddEngineUserTaskJobsEvent<T>(
            this IServiceCollection services)
            where T : ICompleteUserTaskEvent
        {
            services.AddTransient(typeof(ICompleteUserTaskEvent), typeof(T));
        }
    }
}
