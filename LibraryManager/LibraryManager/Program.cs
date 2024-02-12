using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder();

        var service = host.Services.GetRequiredService<ICatalogService>();

        host.Run();
    }

    private static IHost CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddScoped<ICatalogService, CatalogService>();

                services.AddScoped<ICatalogManager, CatalogManager>();

                services.AddScoped<IRepository<Author>, AuthorRepository>();
                services.AddScoped<IRepository<Book>, BookRepository>();
                services.AddScoped<IRepository<Library>, LibraryRepository>();

                services.AddDbContext<LibraryContext>();
            })
            .Build();
    }
}