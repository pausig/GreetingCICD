namespace GreetingCICD.ChainOfResponsibility;

public interface IGreetingHandler
{
    IGreetingHandler SetNext(IGreetingHandler greetingHandler);
    string Handle(string name);
}