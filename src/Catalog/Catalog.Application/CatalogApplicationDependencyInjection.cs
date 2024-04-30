using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Application;

public static class CatalogApplicationDependencyInjection 
{
    public static IServiceCollection AddCatalogApplicationDependencyInjection(this IServiceCollection service)
    {
        service.AddMediatR(Assembly.GetExecutingAssembly());

        return service;
    }
}