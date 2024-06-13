# Pomodoros (25 minute blocks)

* Analyze initial requirements. Done. 

* Review demo projects from dotnet/blazor-samples/8.0. Done.

* Create new GitHub repository with a Blazor WebAssembly client app.

* Uninstall old versions of .NET, install .NET 8.0 SDK. Done.

* Introduce Blazor component unit tests. Done.

* Handle service injection in the component test. Done.

* Implement an IWeatherService that consumes the WeatherAPI.com service. Done.

* Break out the list of cities into its own component.

# Requirements

* [x] Create a user interface for user to search for weather in a city. 
* [ ] User the public WeatherAPI to obtain weather information. 
* [x] Use the provided API key.
* [x] Use proper API key management. 
* [x] Display the search results using the Search/Autocomplete service.
* [ ] Display the weather information for the selected city using WeatherAPI data.
* [ ] Allow users to save cities as favorites and view their list of favorites.

# Design 

* [x] Create a homepage that allows users to search for the weather in a city.
* [ ] Create a component for the city list and use it in the lists.
* [ ] Create a results page that shows the weather for the selected city.
* [ ] Include current temparature in F and C, Feels Like...

# Thursday 13 June 2024

```
dotnet new install bunit.template
dotnet new bunit --targetSdk net8.0 --framework xunit -o WeatherApp.WebUI.Tests
dotnet sln add .\WeatherApp.WebUI.Tests\WeatherApp.WebUI.Tests.csproj
dotnet add .\WeatherApp.WebUI.Tests\WeatherApp.WebUI.Tests.csproj reference .\WeatherApp.WebUI\WeatherApp.WebUI.csproj
dotnet user-secrets --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj init
dotnet user-secrets --project .\WeatherApp.WebUI\WeatherApp.WebUI.csproj set "WeatherApiKey" "<SECRET>"
```

Resources:

- https://learn.microsoft.com/en-us/aspnet/core/blazor/components/event-handling
- https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests

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
