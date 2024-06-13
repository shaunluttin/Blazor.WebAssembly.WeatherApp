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

    public async Task<WeatherReport> GetCurrentWeatherByCityId(int cityId)
    {
        var requestUri = $"current.json?key={_apiKey}&q=id:{cityId}";
        var result = await _httpClient.GetFromJsonAsync<WeatherReport>(requestUri);
        return result;
    }

    public async Task<City[]> SearchCities(string searchTerm)
    {
        var requestUri = $"search.json?key={_apiKey}&q=${searchTerm}";
        var results = await _httpClient.GetFromJsonAsync<City[]>(requestUri);
        return results ?? [];
    }
}