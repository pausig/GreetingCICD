using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class ManyNamesHandlerTests
{
    private IGreetingHandler _handler;

    public ManyNamesHandlerTests()
    {
        _handler = new ManyNamesGreetingHandler();
    }

    [Fact]
    public void Should_Return_Combined_Greeting_When_Multiple_Strings_In_Input()
    {
        Assert.Equal("Hello, Bob and John", _handler.Handle(["Bob", "John"]));
        Assert.Equal("Hello, Bob, John and Brian", _handler.Handle(["Bob", "John", "Brian"]));
    }
}
