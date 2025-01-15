namespace GreetingCICD.ChainOfResponsibility;

public class CommaGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        var commaNames = names.Where(name => name.Contains(','));
        if (commaNames.Any())
        {
            var newNames = names.SelectMany(n => n.Split(','))
                                .Select(n => n.Trim())
                                .ToArray();

            return base.Handle(newNames);
        }

        return base.Handle(names);
    }
}