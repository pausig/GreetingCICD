namespace GreetingCICD.ChainOfResponsibility;

public class SomeShoutingGreetingHandler : AbstractGreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names.Length >= 2)
        {
            var shouting = names.Where(name => name.All(char.IsUpper))
                                .Select(name => name);

            if (shouting.Any())
            {
                var notShouting = names.Except(shouting);

                return $"Hello, {CombineNames(notShouting)}. " +
                       $"AND HELLO {CombineNames(shouting).ToUpper()}!";                
            }
        }

        return base.Handle(names);
    }

    private string CombineNames(IEnumerable<string> names)
    {
        if (names.Count() == 2)
            return $"{names.First()} and {names.Last()}";

        return string.Join(", ", names);
    }
}