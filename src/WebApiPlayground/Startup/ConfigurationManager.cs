namespace WebApiPlayground.Startup;

public static class ConfigurationManager
{
    /// <summary>
    /// NOTE: This method will be removed once appsettings deployment works.
    /// </summary>
    /// <param name="app">the WebApplication being built</param>
    /// <param name="configuration">the configuration used for the service buildup (appsettings.*.json)</param>
    public static void CheckConfiguration(this WebApplication app, IConfiguration configuration)
    {
        var defaultEnvVariable = configuration.GetValue<string>("DefaultEnvironmentVariable");
        var logger = app.Logger;
        logger.LogInformation($"ENV VARIABLE: {defaultEnvVariable}");
    }
}