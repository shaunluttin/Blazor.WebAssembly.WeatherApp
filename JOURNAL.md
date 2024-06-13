# Pomodoros (25 minute blocks)

* Analyze initial requirements. Done. 

* Review demo projects from dotnet/blazor-samples/8.0. Done.

* Create new GitHub repository with a Blazor WebAssembly client app.

* Uninstall old versions of .NET, install .NET 8.0 SDK. Done.

* Implement an IWeatherService that consumes the WeatherAPI.com service.*

# Thursday 13 June 2024

```
dotnet new install bunit.template
dotnet new bunit --targetSdk net8.0 --framework xunit -o WeatherApp.WebUI.Tests
dotnet sln add .\WeatherApp.WebUI.Tests\WeatherApp.WebUI.Tests.csproj
dotnet add .\WeatherApp.WebUI.Tests\WeatherApp.WebUI.Tests.csproj reference .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
```

# Wednesday 12 June 2024

Use Blazor Web App instead of Blazor WebAssembly because:
- it allows us to keep the WeatherAPI key private,
- it provides out-of-the-box client/server communication.

Resources:

- https://www.weatherapi.com/api-explorer.aspx
- https://github.com/dotnet/blazor-samples/tree/main/8.0

Useful Commands
```
dotnet new sln
dotnet new list blazer
dotnet new blazorwasm --framework net8.0 --pwa --name WeatherApp.WebUI
dotnet watch run --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
dotnet sln add .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
dotnet new blazor --framework net8.0 --name WeatherApp.WebUI
```
