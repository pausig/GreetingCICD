namespace GreetingCICD.ChainOfResponsibility;

public class NullGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names == null || names.Length == 0)
            return "Hello, my friend";

        return base.Handle(names);
    }
}