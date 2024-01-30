using BusinessLayer.Catalog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder();
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<ICatalogService, CatalogService>();
                services.AddSingleton<ICatalogManager, CatalogManager>();
                //services.AddDbContext<DataContext>(options =>
                //{
                //    options.UseSqlite(connectionString);
                //});
            });
    }
}
