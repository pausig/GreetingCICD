using GreetingCICD.Services;

namespace GreetingCICD.Tests;

public class GreetingTests
{
    private IGreetingService _greetingService;

    public GreetingTests()
    {
        _greetingService = Container.GetService<IGreetingService>();
    }

    [Fact]
    public void Should_Return_Greeting_When_Input_String_Is_Name()
    {
        Assert.Equal("Hello, Bob", _greetingService.Greet("Bob"));
    }
}