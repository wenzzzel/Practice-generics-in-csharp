namespace Practice_generics_in_csharp.Interfaces;

public interface ICustomLogger<T>
{
    public void LogInformation(string message);
}