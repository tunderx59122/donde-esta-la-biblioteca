using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using BusinessLayer.Catalog;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                // Configuration des services
            })
            .Build();
    }
}