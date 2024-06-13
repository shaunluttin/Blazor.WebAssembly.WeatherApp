using WeatherApp.WebUI.DTOs;

namespace WeatherApp.WebUI.Services;

// TODO Consider using a more declarative naming convention.
// E.g.,
//     .CitiesSearch(searchTerm)
//     .CurrentWeather(cityId)
//     .ForecastedWeather(cityId, daysIntoFuture);
public interface IWeatherService
{
    Task<WeatherLocationDTO[]> SearchCities(string searchTerm);

    Task<CurrentWeatherDTO> GetCurrentWeatherByCityId(int cityId);

    Task<ForecastedWeatherDTO> GetWeatherForecastByCityId(int cityId, int days);
}
