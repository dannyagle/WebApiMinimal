namespace WebApiMinimal.Models;

public record WeatherForecast(DateTime Date, int Celsius, string? Summary)
{
    public int Farenheight => 32 + (int)(Celsius / 0.5556);
}
