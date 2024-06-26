using WeatherApp.WebUI.DTOs;
using WeatherApp.WebUI.Extensions;

namespace WeatherApp.WebUI.Services;

public class WeatherApiServiceV1 : IWeatherService
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public WeatherApiServiceV1(IConfiguration config, HttpClient httpClient)
    {
        // See also
        _apiKey = config.GetOrThrow("DEMO_WeatherApiKey");
        _httpClient = httpClient;
    }

    public async Task<CurrentWeatherDTO> GetCurrentWeatherByCityId(int cityId)
    {
        var requestPath = $"current.json?key={_apiKey}&q=id:{cityId}";
        var result = await _httpClient.GetFromJsonAsync<CurrentWeatherDTO>(requestPath);

        if (result == null)
        {
            throw new FileNotFoundException($"No weather results for {nameof(cityId)}:{cityId}.");
        }

        return result;
    }

    public async Task<ForecastedWeatherDTO> GetWeatherForecastByCityId(int cityId, int days)
    {
        var requestPath = $"forecast.json?key={_apiKey}&q=id:{cityId}&days={days}&aqi=no&alerts=no";
        var result = await _httpClient.GetFromJsonAsync<ForecastedWeatherDTO>(requestPath);

        if (result == null)
        {
            throw new FileNotFoundException($"No forecast results for {nameof(cityId)}:{cityId}.");
        }

        return result;
    }

    public async Task<WeatherLocationDTO[]> SearchCities(string searchTerm)
    {
        var requestUri = $"search.json?key={_apiKey}&q=${searchTerm}";
        var results = await _httpClient.GetFromJsonAsync<WeatherLocationDTO[]>(requestUri);
        return results ?? [];
    }
}