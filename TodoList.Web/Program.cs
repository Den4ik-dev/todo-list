using TodoList.Application;
using TodoList.Infrastructure;
using TodoList.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebServices();

WebApplication app = builder.Build();

app.MapControllers();

app.Run();
