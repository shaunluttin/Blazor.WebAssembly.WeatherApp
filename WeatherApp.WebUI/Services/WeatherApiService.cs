using WeatherApp.WebUI.Models;

namespace WeatherApp.WebUI.Services;

public class WeatherApiService : IWeatherService
{
    public Task<City[]> GetCities()
    {
        return Task.FromResult<City[]>([new City(), new City()]);
    }
}