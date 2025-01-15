using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD.Tests;

public class CommaHandlerTests
{
    private IGreetingHandler _handler;

    public CommaHandlerTests()
    {
        _handler = new CommaGreetingHandler();
        _handler.SetNext(new ManyNamesGreetingHandler()); // base handler
    }

    [Fact]
    public void Should_Handle_Commas_In_Input_Strings()
    {
        Assert.Equal("Hello, Bob, Jake and Luke", _handler.Handle(["Bob", "Jake, Luke"]));
    }

    [Fact]
    public void Should_Handle_Escaped_Commas_In_Input_Strings()
    {
        Assert.Equal("Hello, Bob and Luke, Jake", _handler.Handle(["Bob", "\"Luke, Jake\""]));
        Assert.Equal("Hello, Bob, Jake and John, Luke", _handler.Handle(["\"Bob, Jake\"", "\"John, Luke\""]));
    }
}
