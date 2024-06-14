using System.Text.Json.Serialization;

namespace WeatherApp.WebUI.DTOs;

public class ForecastedWeatherDTO
{
    public WeatherLocationDTO? Location { get; set; }

    [JsonPropertyName("forecast")]
    public ForecastDTO Forecast { get; set; }
}

public class ForecastDTO
{
    [JsonPropertyName("forecastday")]
    public ForecastDayDTO[] ForecastDay { get; set; }
}

public class ForecastDayDTO
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("date_epoch")]
    public int UnixTime { get; set; }

    [JsonPropertyName("day")]
    public ForecastDescriptionDTO Day { get; set; }

}

public class ForecastDescriptionDTO
{
    [JsonPropertyName("avgtemp_f")]
    public double AverageFahrenheit { get; set; }

    [JsonPropertyName("avgtemp_c")]
    public double AverageCelcius { get; set; }

    [JsonPropertyName("mintemp_f")]
    public double MinFahrenheit { get; set; }

    [JsonPropertyName("mintemp_c")]
    public double MinCelcius { get; set; }

    [JsonPropertyName("maxtemp_f")]
    public double MaxFahrenheit { get; set; }

    [JsonPropertyName("maxtemp_c")]
    public double MaxCelcius { get; set; }
}