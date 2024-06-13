namespace WeatherApp.WebUI.Models;

public class City
{
    public string Name { get; set; }
    public string Id { get; set; }

    public City()
    {
        Name = "Foo";
        Id = "Bar";
    }
}
