using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class SomeShoutingHandlerTests
{
    private IGreetingHandler _handler;

    public SomeShoutingHandlerTests()
    {
        _handler = new SomeShoutingGreetingHandler();
    }

    [Fact]
    public void Should_Return_Shouting_Greeting_When_Uppercase_Input()
    {
        Assert.Equal("Hello, Bob. AND HELLO BRIAN!", _handler.Handle(["Bob", "BRIAN"]));
        Assert.Equal("Hello, Bob and Luke. AND HELLO BRIAN!", _handler.Handle(["Bob", "Luke", "BRIAN"]));
        Assert.Equal("Hello, Bob and Luke. AND HELLO BRIAN AND JOHN!", _handler.Handle(["Bob", "Luke", "BRIAN", "JOHN"]));
    }
}