using WebApiPlayground.Infrastructure.ApiEndpoints;
using WebApiPlayground.Infrastructure.Database;
using WebApiPlayground.Infrastructure.Swagger;
using WebApiPlayground.Startup;

var bld = WebApplication.CreateBuilder();
bld.Services.AddApiEndpoints();
bld.Services.AddSwagger();
bld.Services.AddSqlServerService();

var app = bld.Build();
app.UseApiEndpoints();
app.UseSwagger();

// Debug calls
app.CheckConfiguration(bld.Configuration);

app.Run();

public partial class Program { }