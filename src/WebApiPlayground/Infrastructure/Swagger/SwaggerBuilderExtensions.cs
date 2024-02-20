using WebApiPlayground.Startup;

namespace WebApiPlayground.Infrastructure.Swagger;

public static class ServiceExtensions
{
    public static void AddSwaggerDocument(this IServiceCollection services)
    {
        services.SwaggerDocument(options =>
        {
            options.DocumentSettings = s =>
            {
                s.Title = AppConstants.AppName;
                s.Version = AppConstants.Version;
                s.Description = AppConstants.Description;
            };
        });
    }
    
    public static void UseSwaggerDocument(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment()) return;
        
        app.UseSwaggerGen();
        app.UseSwaggerUi();
    }
}