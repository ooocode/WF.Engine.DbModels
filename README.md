# NetCore

## 支持 ASP.Net Core 6.0/7.0
## 工作流引擎 Camunda 7.17
## JDK 11+
## 数据库 Postgresql 11+

## 1、安装Nuget包 "WF.Engine.DbModels"

## 2、启动代码
```csharp
var builder = WebApplication.CreateBuilder(args);

//数据库字符串
var dbConnectString = "server=127.0.0.1;" +
        "database=Test-Engine-0320-1;" +
        "user id=postgres;password=12345678";
//自动创建数据库
var autoCreateDb = true;

//工作流引擎GRPC地址，如果空，则启用内置
var engineGrpcAddress = string.Empty;

//添加数据库上下文和工作流引擎接口
builder.Services.AddEngineDbContextAndGrpcClient(dbConnectString,
    autoCreateDb,
    engineGrpcAddress);

//添加完成任务回调
builder.Services.AddEngineUserTaskJobs(TimeSpan.FromSeconds(60), true);
builder.Services.AddEngineUserTaskJobsEvent<MyCompleteUserTaskEvent>();


```

## 3、依赖注入接口
```csharp
引擎数据库（导出Camunda所有表）： EngineDbContext engineDbContext
引擎数据库工厂（导出Camunda所有表）： IDbContextFactory<EngineDbContext> dbContextFactory
Grpc客户端：ProcessService.ProcessServiceClient processServiceClient
```

## 4、查询数据库示例(EF Core Linq)
```csharp
        /// <summary>
        /// 获取待办任务数量
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("todo-count")]
        public async Task<int> GetTodoCount(string userId)
        {
            var list = await engineDbContext.ActRuTasks.AsNoTracking()
                .CountAsync(e => e.Assignee == userId);

            return list;
        }
```

### 5、发起流程和完成任务（Grpc）
```csharp
            //发起流程
            var req = new StartProcessRequest
            {
                AuthenticatedUserId = value.UserId,
                BusinessKey = Guid.NewGuid().ToString(),
                ProcessDefinitionKey = value.ProcessDefinitionKey
            };
            StartProcessReply res = await processServiceClient.StartProcessAsync(req);

            //完成任务
            var body = new CompleteTaskRequest
            {
                TaskId = value.UserTaskId,
            };
            var res = await processServiceClient.CompleteUserTaskAsync(body);
```

### 默认端口：
#### Grpc 9999
#### 引擎Web 5003 （camunda设计器、后台）