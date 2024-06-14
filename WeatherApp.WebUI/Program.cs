using WeatherApp.WebUI.Components;
using WeatherApp.WebUI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register third-party WeatherAPI service with an HTTP Client.
builder.Services.AddSingleton<IWeatherService, WeatherApiServiceV1>();
builder.Services.AddHttpClient<IWeatherService, WeatherApiServiceV1>(client => 
{
    // The base address probably has to end with a trailing slash.
    var baseAddress = builder.Configuration["WeatherApiBaseAddress"];
    client.BaseAddress = new Uri(baseAddress);
});

// Register internal WeatherApp service with an HTTP Client.
builder.Services.AddSingleton<IFavoritesService, FavoritesService>();
builder.Services.AddHttpClient<IFavoritesService, FavoritesService>(client => 
{
    // The base address probably has to end with a trailing slash.
    var baseAddress = builder.Configuration["InternalApiBaseAddress"];
    client.BaseAddress = new Uri(baseAddress);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
