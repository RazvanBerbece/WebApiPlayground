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
        var defaultConfigVariable = configuration.GetValue<string>("DefaultConfigurationVariable");
        var defaultSecretKey = configuration.GetValue<string>("DefaultSecretKey");
        var logger = app.Logger;
        logger.LogInformation($"ENV VARIABLE: {defaultConfigVariable}");
        logger.LogInformation($"SECRET KEY: {defaultSecretKey}");
    }
}