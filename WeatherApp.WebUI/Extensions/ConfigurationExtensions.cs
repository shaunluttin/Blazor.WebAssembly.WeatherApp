namespace WeatherApp.WebUI.Extensions;

public static class ConfigurationExtensions 
{
    public static string GetOrThrow(this IConfiguration config, string key) 
    {
        var result = config[key];

        if (result == null)
        {
            throw new InvalidOperationException($"Missing configuration for key {key}.");
        }

        return result;
    }
}