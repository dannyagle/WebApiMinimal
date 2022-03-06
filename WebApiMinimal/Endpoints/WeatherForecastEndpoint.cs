using FastEndpoints;
using WebApiMinimal.Requests;
using WebApiMinimal.Responses;
using WebApiMinimal.Services;

namespace WebApiMinimal.Endpoints;

public class WeatherForecastEndpoint : Endpoint<WeatherForecastRequest,WeatherForecastsResponse>
{
    public IWeatherForecastService Service { get; init; }

    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("forecast/{days}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(WeatherForecastRequest request, CancellationToken cancellationToken)
    {
        var response = new WeatherForecastsResponse
        {
            WeatherForecasts = (await Service.GetForecastAsync(request.Days))
                .Select(x => new WeatherForecastResponse(x.Date, x.Celsius, x.Farenheight, x.Summary))
                .AsEnumerable()
        };

        await SendAsync(response, cancellation: cancellationToken);
    }
}
