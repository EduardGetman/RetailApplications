using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class ShipmentDestinationConfiguration : BaseDomainConfiguration<ShipmentDestination>
{
    public override void Configure(EntityTypeBuilder<ShipmentDestination> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Code)
            .IsRequired();

        builder.Property(p => p.Adress)
            .IsRequired();
    }
}