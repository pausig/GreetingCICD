using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using GreetingCICD.Services;
using GreetingCICD.ChainOfResponsibility;

namespace GreetingCICD;

public class Container
{
    private static IHost CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
                   .ConfigureServices((services) =>
                        services.AddSingleton<IGreetingService, GreetingService>()
                                .AddSingleton<IGreetingHandler, NameGreetingHandler>())
                   .Build();
    }

    public static T GetService<T>()
    {
        return CreateHostBuilder().Services.GetService<T>();
    }
}