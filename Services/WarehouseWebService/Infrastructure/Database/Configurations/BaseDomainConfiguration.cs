﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Database.Configurations;

internal abstract class BaseDomainConfiguration<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : DomainBase
{
    public virtual void Configure(EntityTypeBuilder<TDomain> builder)
    {
        builder.ToTable(typeof(TDomain).Name);
        builder.HasKey(p => p.Id);
    }
}