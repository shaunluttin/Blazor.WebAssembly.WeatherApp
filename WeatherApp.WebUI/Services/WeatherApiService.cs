using WeatherApp.WebUI.Models;

namespace WeatherApp.WebUI.Services;

public class WeatherApiService : IWeatherService
{
    private readonly string? _apiKey;
    private readonly HttpClient _httpClient;

    public WeatherApiService(IConfiguration config, HttpClient httpClient)
    {
        // See also 
        _apiKey = config["WeatherApiKey"];
        _httpClient = httpClient;
    }

    public async Task<WeatherLocationReport> GetCurrentWeatherByCityId(int cityId)
    {
        var requestUri = $"current.json?key={_apiKey}&q=id:{cityId}";

        var temp = await _httpClient.GetAsync(requestUri);
        var tempToo = await temp.Content.ReadAsStringAsync();
        Console.WriteLine(tempToo);

        var result = await _httpClient.GetFromJsonAsync<WeatherLocationReport>(requestUri);
        return result;
    }

    public async Task<WeatherLocation[]> SearchCities(string searchTerm)
    {
        var requestUri = $"search.json?key={_apiKey}&q=${searchTerm}";
        var results = await _httpClient.GetFromJsonAsync<WeatherLocation[]>(requestUri);
        return results ?? [];
    }
}