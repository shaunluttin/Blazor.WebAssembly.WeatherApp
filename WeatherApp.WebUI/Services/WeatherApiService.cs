using WeatherApp.WebUI.Models;

namespace WeatherApp.WebUI.Services;

public class WeatherApiService : IWeatherService
{
    private readonly string? _apiKey;
    private readonly HttpClient _httpClient;

    public WeatherApiService(IConfiguration config, HttpClient httpClient)
    {
        // See also https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets
        _apiKey = config["WeatherApiKey"];
        _httpClient = httpClient;
    }

    public async Task<City[]> SearchCities()
    {
        var results = await _httpClient.GetFromJsonAsync<City[]>($"/search.json?key={_apiKey}&q=Vancouver");
        return results ?? [];
    }
}