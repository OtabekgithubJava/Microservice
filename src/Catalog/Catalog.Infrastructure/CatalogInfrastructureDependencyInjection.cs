using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Catalog.Infrastructure.Persistence;

namespace Catalog.Infrastructure
{
    public static class CatalogInfrastructureDependencyInjection
    {
        public static IServiceCollection AddCatalogInfrastructureDependencyInjection(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Connect"));
            });

            return services;
        }
    }
}