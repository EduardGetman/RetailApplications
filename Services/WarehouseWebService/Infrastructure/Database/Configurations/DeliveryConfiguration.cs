using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class DeliveryConfiguration : BaseDomainConfiguration<Delivery>
{
    public override void Configure(EntityTypeBuilder<Delivery> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Volume)
            .IsRequired();

        builder.Property(p => p.DateTime)
            .IsRequired();
    }
}