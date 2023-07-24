using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class WarehouseConfiguration : BaseDomainConfiguration<Warehouse>
{
    public override void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Code)
            .IsRequired();

        builder.Property(p => p.Adress)
            .IsRequired();
    }
}