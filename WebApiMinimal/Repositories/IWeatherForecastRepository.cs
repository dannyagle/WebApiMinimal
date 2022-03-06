using WebApiMinimal.Models;

namespace WebApiMinimal.Repositories;

public interface IWeatherForecastRepository
{
    Task<IEnumerable<WeatherForecast>> GetForecastsAsync(int days);
}
