using WeatherApp.WebUI.DTOs;
using WeatherApp.WebUI.Extensions;

namespace WeatherApp.WebUI.Services;

public class FavoritesService : IFavoritesService
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public FavoritesService(IConfiguration config, HttpClient httpClient)
    {
        // TODO Use an Internal API Key to protect the internal API.
        _apiKey = config.GetOrThrow("DEMO_InternalApiKey");
        _httpClient = httpClient;
    }

    public async Task AddFavorite(int cityId, string cityName)
    {
        var requestPath = "favorites";
        await _httpClient.PostAsJsonAsync(requestPath, new { cityId, cityName });
    }

    public async Task<FavoriteCityDTO[]> GetFavorites()
    {
        var requestPath = "favorites";
        var result = await _httpClient.GetFromJsonAsync<FavoriteCityDTO[]>(requestPath);
        return result ?? [];
    }

    public async Task<bool> IsFavorite(int cityId)
    {
        var favorites = await GetFavorites();
        return favorites.Any(f => f.CityId == cityId);
    }

    public async Task RemoveFavorite(int cityId)
    {
        var requestPath = $"favorites?cityId={cityId}";
        await _httpClient.DeleteAsync(requestPath);
    }
}