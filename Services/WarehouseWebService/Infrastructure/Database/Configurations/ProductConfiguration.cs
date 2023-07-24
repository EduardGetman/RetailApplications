using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Common.Enums;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal class ProductConfiguration : BaseDomainConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.MeasurementUnits)
            .HasConversion(x=> x.ToString(), x=> Enum.Parse<MeasurementUnitsKind>(x))
            .HasDefaultValue(MeasurementUnitsKind.Piece);

        builder.Property(p => p.Name);
        
        builder.Property(p => p.Code)
            .IsRequired();
    }
}