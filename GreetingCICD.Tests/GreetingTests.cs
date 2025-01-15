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
        Assert.Equal("Hello, Bob", _greetingService.Greet(["Bob"]));
    }

    [Fact]
    public void Should_Return_Generic_Greeting_When_Input_String_Is_Null_Or_Empty()
    {
        Assert.Equal("Hello, my friend", _greetingService.Greet(null));
        Assert.Equal("Hello, my friend", _greetingService.Greet([]));
    }

    [Fact]
    public void Should_Return_Shouting_Greeting_When_Input_String_Is_Uppercase()
    {
        Assert.Equal("HELLO, BOB", _greetingService.Greet(["BOB"]));
    }

    [Fact]
    public void Should_Return_Combined_Greeting_When_Input_Is_Two_Strings()
    {
        Assert.Equal("Hello, Bob and John", _greetingService.Greet(["Bob", "John"]));
    }

    [Fact]
    public void Should_Return_Combined_Greeting_When_Input_Is_More_Than_Two_Strings()
    {
        Assert.Equal("Hello, Bob, John and Brian", _greetingService.Greet(["Bob", "John", "Brian"]));
    }
}