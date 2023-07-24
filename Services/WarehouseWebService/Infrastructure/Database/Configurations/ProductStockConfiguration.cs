using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class ProductStockConfiguration : BaseDomainConfiguration<ProductStock>
{
    public override void Configure(EntityTypeBuilder<ProductStock> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Volume)
            .IsRequired();
    }
}