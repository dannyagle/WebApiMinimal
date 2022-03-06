namespace WebApiMinimal.Responses;

public class WeatherForecastsResponse
{
    public IEnumerable<WeatherForecastResponse> WeatherForecasts { get; set; }
}
