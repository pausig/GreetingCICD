using GreetingCICD.Services;

namespace GreetingCICD;

internal class Program
{
    static void Main(string[] args)
    {
        IGreetingService greetingService = Container.GetService<IGreetingService>();
        string? greeting = greetingService.Greet(["Bob"]);
        Console.WriteLine(greeting);
    }
}