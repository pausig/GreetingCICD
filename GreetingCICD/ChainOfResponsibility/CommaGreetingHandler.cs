namespace GreetingCICD.ChainOfResponsibility;

public class CommaGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        var commaNames = names.Where(name => name.Contains(','));
        if (commaNames.Any())
        {
            var newNames = ProcessCommas(names)
                            .Select(n => n.Trim())
                            .ToArray();

            return base.Handle(newNames);
        }

        return base.Handle(names);
    }

    private IEnumerable<string> ProcessCommas(string[] names)
    {
        return names.SelectMany(n => {
            if (n.First().Equals('\"') && n.Last().Equals('\"'))
                return [
                    n.Trim('\"')
                ];
            else
                return n.Split(',');
        });
    }
}