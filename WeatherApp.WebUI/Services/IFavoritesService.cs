using WeatherApp.WebUI.DTOs;

namespace WeatherApp.WebUI.Services;

public interface IFavoritesService
{
    Task<FavoriteCityDTO[]> GetFavorites();

    Task AddFavorite(int cityId, string cityName);

    Task RemoveFavorite(int cityId);

    Task<bool> IsFavorite(int cityId);
}
