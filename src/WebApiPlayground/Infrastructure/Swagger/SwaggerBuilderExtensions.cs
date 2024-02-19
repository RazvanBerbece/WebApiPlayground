namespace WebApiPlayground.Infrastructure.Swagger;

public static class SwaggerBuilderExtensions
{
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        return services.SwaggerDocument();
    }
    
    public static IApplicationBuilder UseSwagger(this IApplicationBuilder app)
    {
        return app.UseSwaggerGen();
    }
}