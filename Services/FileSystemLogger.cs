using Practice_generics_in_csharp.Interfaces;

namespace Practice_generics_in_csharp.Services;

public class FileSystemLogger : ICustomLogger<FileSystemLogger>
{
    public void LogInformation(string message)
    {
        System.Console.WriteLine($"Logging this to file system: {message}");
    }
}
