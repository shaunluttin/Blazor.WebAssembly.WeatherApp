# blazor-weather-app

Demo Blazer Web Assembly web application.

## Usuage

```powershell
# Clone the app and enter its directory.
git clone git@github.com:shaunluttin/Blazor.WebAssembly.WeatherApp.git
cd Blazor.WebAssembly.WeatherApp

# Run the API in one terminal window.
# Its launchSettings.json sets port 5050 over HTTP and 7166 over HTTPS
dotnet watch run --project .\WeatherApp.WebAPI\WeatherApp.WebAPI.csproj

# Run the UI in another terminal window.
# Its launchSettings.json sets port 5008 over HTTP and 7084 over HTTPS
dotnet user-secrets --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj set "DEMO_WeatherApiKey" "<API_SECRET_KEY>"
dotnet watch run --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
```

![](./DeveloperNotes/demo-weather-app.gif)

This GIF very simply demonstrates the usuage instructions from PowerShell.

For the `API_SECRET_KEY`, you will need an API key for the https://www.weatherapi.com/ service.
