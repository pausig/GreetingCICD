namespace GreetingCICD.ChainOfResponsibility;

public class ManyNamesGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names.Length >= 2)
        {
            string namesList = string.Join(", ", names.SkipLast(1));
            return $"Hello, {namesList} and {names.Last()}";
        }

        return base.Handle(names);
    }
}