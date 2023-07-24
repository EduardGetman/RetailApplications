using AutoMapper;
using WarehouseWebService.Infrastructure.Mapping;

namespace WarehouseWebService.Common.Extensions.Configurations;

public static class AutoMapperExtension
{
    public static IServiceCollection AddConfiguredAutoMapper(this IServiceCollection services) 
        => services.AddAutoMapper(Configure);

    private static void Configure(IMapperConfigurationExpression x)
    {
        x.AddProfile(new DtoDomainProfile());
        x.AllowNullCollections = true;
        x.AllowNullDestinationValues = true;
    }
}