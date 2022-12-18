using Microsoft.AspNetCore.Mvc;
using Practice_generics_in_csharp.Services;

namespace Practice_generics_in_csharp.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecast2Controller : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly LoggingService<ConsoleLogger> loggingService;

    public WeatherForecast2Controller()
    {
        this.loggingService = new LoggingService<ConsoleLogger>(new ConsoleLogger());
    }

    [HttpGet(Name = "GetWeatherForecast2")]
    public IEnumerable<WeatherForecast> Get()
    {
        loggingService.Log("Running GetWeatherForecast2");

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
