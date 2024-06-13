using WeatherApp.WebUI.Models;

namespace WeatherApp.WebUI.Services;

public interface IWeatherService
{
    Task<City[]> SearchCities();
}