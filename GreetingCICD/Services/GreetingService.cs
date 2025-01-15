using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Services;

public class GreetingService : IGreetingService
{
    private readonly IGreetingHandler _greetingHandler;

    public GreetingService(IGreetingHandler greetingHandler)
    {
        _greetingHandler = greetingHandler;
    }

    public string Greet(string[] names)
    {
        return _greetingHandler.Handle(names);
    }
}