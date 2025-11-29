using System.Text.Json.Serialization;

namespace BlazorBootStrap.Client.Models;

public class OpenMeteoResponse
{
    [JsonPropertyName("latitude")]
public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("current")]
    public CurrentWeather? Current { get; set; }

    [JsonPropertyName("hourly")]
    public HourlyWeather? Hourly { get; set; }
}

public class CurrentWeather
{
    [JsonPropertyName("temperature_2m")]
    public double Temperature { get; set; }

    [JsonPropertyName("wind_speed_10m")]
public double WindSpeed { get; set; }
}

public class HourlyWeather
{
    [JsonPropertyName("time")]
    public List<string>? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
  public List<double>? Temperature { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public List<int>? RelativeHumidity { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public List<double>? WindSpeed { get; set; }
}
