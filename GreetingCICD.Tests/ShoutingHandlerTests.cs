using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class ShoutingHandlerTests
{
    private IGreetingHandler _handler;

    public ShoutingHandlerTests()
    {
        _handler = new ShoutingGreetingHandler();
    }

    [Fact]
    public void Should_Return_Shouting_Greeting_When_Uppercase_Input()
    {
        Assert.Equal("HELLO, BOB", _handler.Handle(["BOB"]));
    }
}
