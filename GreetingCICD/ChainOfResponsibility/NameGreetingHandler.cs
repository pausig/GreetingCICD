namespace GreetingCICD.ChainOfResponsibility;

public class NameGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string name)
    {
        return $"Hello, {name}";
    }
}