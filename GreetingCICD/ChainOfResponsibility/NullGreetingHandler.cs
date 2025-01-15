namespace GreetingCICD.ChainOfResponsibility;

public class NullGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string name)
    {
        if (string.IsNullOrEmpty(name))
            return "Hello, my friend";

        return base.Handle(name);
    }
}