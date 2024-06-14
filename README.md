# blazor-weather-app

Demo Blazer Web Assembly web application.

## Usuage

```
# Clone the app and enter its directory.
git clone git@github.com:shaunluttin/Blazor.WebAssembly.WeatherApp.git
cd Blazor.WebAssembly.WeatherApp.git

# Run the API in one terminal window.
dotnet watch run --project .\WeatherApp.WebAPI\WeatherApp.WebAPI.csproj

# Run the UI in another terminal window.
dotnet user-secrets --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj set "WeatherApiKey" "<SECRET_KEY>"
dotnet watch run --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
```
