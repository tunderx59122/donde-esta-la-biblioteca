using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;
using System.Linq.Expressions;

public class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder();
        var host = CreateHostBuilder();
        var catalogService = host.Services.GetRequiredService<ICatalogService>();
        try
        {
            foreach (var book in catalogService.ShowCatalog())
            {
                Console.WriteLine($"{book.Name} by {book?.Author?.FirstName} / {book?.Author?.LastName}");
            }

        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);

        }
    }

    private static IHost CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                // Configuration des services
                services.AddSingleton<ICatalogService, CatalogService>();
                services.AddSingleton<ICatalogManager, CatalogManager>();

                services.AddScoped<IGenericRepository<Book>, BookRepository>();
                services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
                services.AddScoped<IGenericRepository<Library>, LibraryRepository>();

                services.AddDbContext<LibraryContext>(options =>
                    options.UseSqlite("Data Source=.\\ressources\\Library.db;")
                );
            }).Build();
    }
}
