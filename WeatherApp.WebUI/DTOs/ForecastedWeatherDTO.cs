using System.Text.Json.Serialization;

namespace WeatherApp.WebUI.DTOs;

public class ForecastedWeatherDTO
{
    public WeatherLocationDTO? Location { get; set; }

    public ForecastDTO Forecast { get; set; }

    public class ForecastDTO
    {
        public ForecastDayDTO[] ForecastDay { get; set; }

        public class ForecastDayDTO
        {
           [JsonPropertyName("date_epoch")]
           public int UnixTime { get; set; } 

           [JsonPropertyName("day")]
           public WeatherDescriptionDTO Day { get; set; }
        }
    }
}