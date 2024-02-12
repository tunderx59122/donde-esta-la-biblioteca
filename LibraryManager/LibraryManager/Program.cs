using BusinessLayer.Catalog;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
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

                services.AddScoped<IGenericRepository<Book>,BookRepository, BookRepository>();
                services.AddScoped<IGenericRepository<Book>,BookRepository, BookRepository>();
                services.AddScoped<IGenericRepository<Book>,BookRepository, BookRepository>();

                services.AddDbContext<LibraryContext>(options =>
                    options.UseSqlite("Data Source=C:\\Users\\laura\\Documents\\Library.db;"

                ));
            })
        .Build();
    }
}
