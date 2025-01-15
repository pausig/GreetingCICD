namespace GreetingCICD.ChainOfResponsibility;

public class ShoutingGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names.First().All(char.IsUpper))
            return $"HELLO, {names.First()}";

        return base.Handle(names);
    }
}