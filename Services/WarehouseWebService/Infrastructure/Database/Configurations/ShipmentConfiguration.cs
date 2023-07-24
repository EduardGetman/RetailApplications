using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class ShipmentConfiguration : BaseDomainConfiguration<Shipment>
{
    public override void Configure(EntityTypeBuilder<Shipment> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Volume)
            .IsRequired();

        builder.Property(p => p.DateTime)
            .IsRequired();
    }
}