namespace WeatherApp.WebUI.DTOs;

public class CurrentWeatherDTO
{
    public WeatherLocationDTO? Location { get; set; }

    public WeatherDescriptionDTO? Current { get; set; }
}
