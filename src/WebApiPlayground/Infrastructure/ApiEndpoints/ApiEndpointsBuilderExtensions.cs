namespace WebApiPlayground.Infrastructure.ApiEndpoints;

public static class ApiEndpointsBuilderExtensions
{
    public static IServiceCollection  AddApiEndpoints(this IServiceCollection services)
    {
        return services.AddFastEndpoints();
    }
    
    public static IApplicationBuilder UseApiEndpoints(this WebApplication app)
    {
        return app.UseFastEndpoints();
    }
}