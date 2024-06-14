
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

    public Task<string[]> GetFavorites()
    {
        return Task.FromResult(new string[] {"", "", ""});
    }
}