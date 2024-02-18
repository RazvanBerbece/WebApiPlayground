using WebApiPlayground.Infrastructure.ApiEndpoints;
using WebApiPlayground.Infrastructure.Swagger;

var bld = WebApplication.CreateBuilder();
bld.Services
    .AddApiEndpoints()
    .AddSwagger();

var app = bld.Build();
app
    .UseApiEndpoints()
    .UseSwagger();

app.Run();

public partial class Program { }