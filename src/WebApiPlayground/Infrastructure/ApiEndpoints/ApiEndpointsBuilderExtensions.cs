namespace WebApiPlayground.Infrastructure.ApiEndpoints;

public static class ServiceExtensions
{
    public static void AddApiEndpoints(this IServiceCollection services)
    {
        services.AddFastEndpoints();
    }
    
    public static void UseApiEndpoints(this WebApplication app)
    {
        app.UseFastEndpoints();
    }
}