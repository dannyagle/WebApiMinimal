using WebApiMinimal.Models;

namespace WebApiMinimal.Services;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecast>> GetForecastAsync(int days);
}
