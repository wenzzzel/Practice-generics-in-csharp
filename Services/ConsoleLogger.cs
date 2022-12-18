using Practice_generics_in_csharp.Interfaces;

namespace Practice_generics_in_csharp.Services;

public class ConsoleLogger : ICustomLogger<ConsoleLogger>
{
    public void LogInformation(string message)
    {
        System.Console.WriteLine($"Logging this to the console: {message}");
    }
}
