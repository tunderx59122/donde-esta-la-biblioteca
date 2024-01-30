using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

public class Program
{
    private static void Main(string[] args)
    {
    }

    //    private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    //    {
    //        return Host.CreateDefaultBuilder()
    //            .ConfigureServices(services =>
    //            {
    // Configuration des services
    //})
    //            .Build();
    //}


    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        var connectionString = configuration.Build().GetConnectionString("DefaultConnection");

        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<ICatalogService, CatalogService>();
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(connectionString);
                });
            });
    }
}
