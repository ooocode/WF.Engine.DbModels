# NetCore

## ASP.Net Core 6.0/7.0

## 安装Nuget包 "WF.Engine.DbModels"

## 启动代码
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

## 查询数据库
```csharp
依赖注入： EngineDbContext engineDbContext
依赖注入： IDbContextFactory<EngineDbContext> dbContextFactory
Grpc客户端：ProcessService.ProcessServiceClient processServiceClient
```