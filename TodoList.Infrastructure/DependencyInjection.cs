using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Application.Common.Interfaces;
using TodoList.Infrastructure.Data;

namespace TodoList.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        string? connectionString = configuration.GetConnectionString("Default");

        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(
            options => options.UseSqlite(connectionString).UseLazyLoadingProxies()
        );

        return services;
    }
}
