using System.Text.Json.Serialization;

namespace WeatherApp.WebUI.Models;

public class WeatherReport
{
    [JsonPropertyName("temp_f")]
    public int Fahrenheit { get; set; }
}