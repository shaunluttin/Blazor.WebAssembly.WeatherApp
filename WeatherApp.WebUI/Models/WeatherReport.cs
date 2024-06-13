using System.Text.Json.Serialization;

namespace WeatherApp.WebUI.Models;

public class WeatherReport
{
    [JsonPropertyName("temp_f")]
    public double Fahrenheit { get; set; }
}