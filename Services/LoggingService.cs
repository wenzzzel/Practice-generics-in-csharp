using Practice_generics_in_csharp.Interfaces;
using System.Runtime.CompilerServices;

namespace Practice_generics_in_csharp.Services;

public class LoggingService<T> where T : ICustomLogger<T>
{
    private readonly T logger;

    public LoggingService(T logger)
    {
        this.logger = logger;
    }

    public void Log(string message)
    {
        Console.WriteLine("beep bop bleep bip plop... (Doing some generic stuff that we allways want to do regardless of what type of logging we do later)");
        logger.LogInformation(message);
    }
}
