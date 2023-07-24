using WarehouseWebService.Application.Services;
using WarehouseWebService.Interfaces;

namespace WarehouseWebService.Common.Extensions.Configurations;

public static class ApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        services.AddSingleton<IWarehouseService, Application.Services.WarehouseService>();
        return services;
    }
}