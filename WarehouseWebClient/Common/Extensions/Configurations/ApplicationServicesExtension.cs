using WarehouseWebClient.Interfaces;
using WarehouseWebClient.Services;

namespace WarehouseWebClient.Common.Extensions.Configurations;

public static class ApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        return services;
    }
}