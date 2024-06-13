using System.Text.Json.Serialization;

namespace WeatherApp.WebUI.Models;

public class WeatherDescription
{
    [JsonPropertyName("temp_f")]
    public double Fahrenheit { get; set; }

    [JsonPropertyName("temp_c")]
    public double Celcius { get; set; }
    
    [JsonPropertyName("feelslike_f")]
    public double FeelsLikeFahrenheit { get; set; }

    [JsonPropertyName("feelslike_c")]
    public double FeelsLikeCelcius { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("pressure_mb")]
    public double AtmosphericPressure {get; set;}

    [JsonPropertyName("wind_mph")]
    public double WindSpeedMph { get; set; }

    [JsonPropertyName("uv")]
    public double UVIndex { get; set; }
}