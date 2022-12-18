using Practice_generics_in_csharp.Interfaces;

namespace Practice_generics_in_csharp.Services;

public class LoggingService : ILoggingService
{
    public void LogInformation(string message)
    {
        System.Console.WriteLine("INFORMATION: Logging using console.writeline");
    }
}
