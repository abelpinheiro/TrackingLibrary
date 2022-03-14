using TL.Catalog.Application.Interfaces;
using TL.Catalog.Application.Services;
using TL.Catalog.Domain.Interfaces;
using TL.Catalog.Infrastructure.Repositories;

namespace TL.Catalog.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthorService, AuthorService>();
        return services;
    }
}