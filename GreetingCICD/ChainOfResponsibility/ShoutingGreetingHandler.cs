namespace GreetingCICD.ChainOfResponsibility;

public class ShoutingGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string name)
    {
        if (name.All(char.IsUpper))
            return $"HELLO, {name}";

        return base.Handle(name);
    }
}