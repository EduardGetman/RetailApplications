using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class SupplierConfiguration : BaseDomainConfiguration<Supplier>
{
    public override void Configure(EntityTypeBuilder<Supplier> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.Code)
            .IsRequired();

        builder.Property(p => p.Name)
            .IsRequired();
    }
}