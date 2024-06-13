using WeatherApp.WebUI.DTOs;

namespace WeatherApp.WebUI.Services;

public interface IWeatherService
{
    Task<WeatherLocationDTO[]> SearchCities(string searchTerm);

    Task<CurrentWeatherDTO> GetCurrentWeatherByCityId(int cityId);
}
