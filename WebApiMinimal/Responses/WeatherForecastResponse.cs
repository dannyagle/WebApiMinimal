namespace WebApiMinimal.Responses;

public record WeatherForecastResponse(DateTime Date, int Celsius, int Farenheight, string? Summary);
