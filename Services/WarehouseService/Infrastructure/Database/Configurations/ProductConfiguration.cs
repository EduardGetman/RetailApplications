﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseService.Common.Enums;
using WarehouseService.Data.Domain;

namespace WarehouseService.Infrastructure.Database.Configurations;

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