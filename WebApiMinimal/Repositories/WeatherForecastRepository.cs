using WebApiMinimal.Models;

namespace WebApiMinimal.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly string[] _summaries;
   
    public WeatherForecastRepository()
    {
        _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }

    public async Task<IEnumerable<WeatherForecast>> GetForecastsAsync(int days) =>
        Enumerable.Range(1, days).Select(index => GetForecast(index));

    private WeatherForecast GetForecast(int day) =>
        new WeatherForecast(
            DateTime.Now.AddDays(day), 
            Random.Shared.Next(-20, 55), 
            _summaries[Random.Shared.Next(_summaries.Length)]
        );
}
