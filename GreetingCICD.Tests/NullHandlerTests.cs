using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class NullHandlerTests
{
    private IGreetingHandler _handler;

    public NullHandlerTests()
    {
        _handler = new NullGreetingHandler();
    }

    [Fact]
    public void Should_Return_Generic_Greeting_When_Null_Or_Empty_Input()
    {
        Assert.Equal("Hello, my friend", _handler.Handle([]));
        Assert.Equal("Hello, my friend", _handler.Handle(null));
    }
}
