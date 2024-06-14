
using WeatherApp.WebUI.DTOs;

namespace WeatherApp.WebUI.Services;

public class FavoritesService : IFavoritesService
{
    private readonly string? _apiKey;
    private readonly HttpClient _httpClient;

    public FavoritesService(IConfiguration config, HttpClient httpClient)
    {
        // TODO Populate and use the Internal API Key.
        _apiKey = config["InternalApiKey"];
        _httpClient = httpClient;
    }

    public async Task<FavoriteCityDTO[]> GetFavorites()
    {
        var requestPath = "favorites";
        var result = await _httpClient.GetFromJsonAsync<FavoriteCityDTO[]>(requestPath);
        return result;
    }
}