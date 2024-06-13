using WeatherApp.WebUI.Models;

namespace WeatherApp.WebUI.Services;

public interface IWeatherService
{
    Task<WeatherLocation[]> SearchCities(string searchTerm);

    Task<WeatherLocationReport> GetCurrentWeatherByCityId(int cityId);
}
