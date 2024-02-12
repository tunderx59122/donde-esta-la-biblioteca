using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Services.Services;

internal class Program
{
    //private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    //{
    //    return Host.CreateDefaultBuilder()
    //        .ConfigureServices(services =>
    //        {
    //            services.AddScoped<ICatalogService, CatalogService>();

    //            services.AddScoped<IGenericRepository<Book>, BookRepository>();
    //            services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
    //            services.AddScoped<IGenericRepository<Library>, LibraryRepository>();

    //            services.AddDbContext<LibraryContext>(options =>
    //            {
    //                options.UseSqlite("Data Source=C:\\Users\\Evan\\Documents\\Github\\donde-esta-la-biblioteca\\ressources\\Library.db;");
    //            });
    //        })
    //        .Build();
    //}

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddScoped<ICatalogService, CatalogService>();
        builder.Services.AddScoped<ICatalogManager, CatalogManager>();
        builder.Services.AddScoped<IGenericRepository<Book>, BookRepository>();
        builder.Services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
        builder.Services.AddScoped<IGenericRepository<Library>, LibraryRepository>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}