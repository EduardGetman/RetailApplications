using Microsoft.EntityFrameworkCore;
using WarehouseService.Data.Domain;
using WarehouseService.Infrastructure.Database.Configurations;

namespace WarehouseService.Infrastructure;

public class WarehouseDbContext: DbContext
{
    public DbSet<Delivery> Deliveries { get; }
    public DbSet<Product> Products { get; }
    public DbSet<ProductStock> ProductStocks { get;}
    public DbSet<Shipment> Shipments { get; }
    public DbSet<ShipmentDestination> ShipmentDestinations { get;}
    public DbSet<Supplier> Suppliers { get; }
    public DbSet<Warehouse> Warehouses { get; }

    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DeliveryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductStockConfiguration());
        modelBuilder.ApplyConfiguration(new ShipmentConfiguration());
        modelBuilder.ApplyConfiguration(new ShipmentDestinationConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}