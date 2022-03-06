using WebApiMinimal.Models;
using WebApiMinimal.Repositories;

namespace WebApiMinimal.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _repository;

    public WeatherForecastService(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<WeatherForecast>> GetForecastAsync(int days) =>
        await _repository.GetForecastsAsync(days);
}
