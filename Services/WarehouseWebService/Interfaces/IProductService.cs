using WarehouseWebService.Data.Domain;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;

namespace WarehouseWebService.Interfaces;

public interface IProductService
{
    Task<ICollection<Product>> GetAsync(WarehouseDbContext warehouseDbContext);
    Task CreateAsync(WarehouseDbContext warehouseDbContext, ICollection<Product> products);
    Task UpdateAsync(WarehouseDbContext warehouseDbContext, ICollection<Product> products);
    Task DeleteAsync(WarehouseDbContext warehouseDbContext, ICollection<long> ids);
}