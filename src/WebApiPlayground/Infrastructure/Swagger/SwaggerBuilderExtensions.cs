namespace WebApiPlayground.Infrastructure.Swagger;

public static class ServiceExtensions
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.SwaggerDocument();
    }
    
    public static void UseSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerGen();
        }
    }
}