namespace GreetingCICD.ChainOfResponsibility;

public class TwoNamesGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names.Length == 2)
            return $"Hello, {names.First()} and {names.Last()}";

        return base.Handle(names);
    }
}