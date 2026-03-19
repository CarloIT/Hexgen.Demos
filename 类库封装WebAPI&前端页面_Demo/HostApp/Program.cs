using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// 1. 添加控制器支持（扫描所有引用程序集）
builder.Services.AddControllers();

var app = builder.Build();

// 2. 配置嵌入式静态文件中间件（相同命名空间下的多个Controller，只需要配置一次）
var assembly = typeof(ApiLibrary.Controllers.TestController).Assembly;
var embeddedFileProvider = new EmbeddedFileProvider(
    assembly,
    baseNamespace: "ApiLibrary"
);

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = embeddedFileProvider,
    RequestPath = "" // 文件在根路径提供
});

// 3. 配置API路由
app.MapControllers();

// 4. 配置SPA回退路由（所有未匹配请求返回index.html）
//app.MapFallbackToFile("index.html");
app.MapFallback(async context =>
{
    context.Response.ContentType = "text/html";
    await using var stream = embeddedFileProvider.GetFileInfo("wwwroot/index.html").CreateReadStream();
    await stream.CopyToAsync(context.Response.Body);
});

app.Run();
