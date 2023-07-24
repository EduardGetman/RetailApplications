using Microsoft.EntityFrameworkCore;
using WarehouseWebService.Data.Domain;
using WarehouseWebService.Infrastructure.Database.Configurations;

namespace WarehouseWebService.Infrastructure.Database;

public class WarehouseDbContext : DbContext
{
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStock> ProductStocks { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<ShipmentDestination> ShipmentDestinations { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
    {
    }

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