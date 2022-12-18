using Microsoft.AspNetCore.Mvc;
using Practice_generics_in_csharp.Interfaces;

namespace Practice_generics_in_csharp.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ILoggingService loggingService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        ILoggingService loggingService)
    {
        _logger = logger;
        this.loggingService = loggingService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        loggingService.LogInformation("Running GetWeatherForecast");
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
