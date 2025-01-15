namespace GreetingCICD.ChainOfResponsibility;

public class NameGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        return $"Hello, {names.First()}";
    }
}