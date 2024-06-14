using WeatherApp.WebUI.DTOs;

namespace WeatherApp.WebUI.Services;

public interface IFavoritesService
{
    Task<string[]> GetFavorites();
}
