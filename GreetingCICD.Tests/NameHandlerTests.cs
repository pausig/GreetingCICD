using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class NameHandlerTests
{
    private IGreetingHandler _handler;

    public NameHandlerTests()
    {
        _handler = new NameGreetingHandler();
    }

    [Fact]
    public void Should_Return_Greeting_When_One_String_Input()
    {
        Assert.Equal("Hello, Bob", _handler.Handle(["Bob"]));
    }
}
