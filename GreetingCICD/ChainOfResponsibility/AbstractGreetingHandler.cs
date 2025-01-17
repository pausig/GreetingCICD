﻿namespace GreetingCICD.ChainOfResponsibility;

public abstract class AbstractGreetingHandler : IGreetingHandler
{
    private IGreetingHandler? _nextGreetingHandler;

    public IGreetingHandler SetNext(IGreetingHandler greetingHandler)
    {
        _nextGreetingHandler = greetingHandler;
        return greetingHandler;
    }

    public virtual string Handle(string[] names) => _nextGreetingHandler?.Handle(names);
}