using WarehouseWebService.Data.Domain;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;

namespace WarehouseWebService.Interfaces;

public interface IWarehouseService
{
    Task<ICollection<Warehouse>> GetAsync(WarehouseDbContext dbContext);
    Task CreateAsync(WarehouseDbContext dbContext, ICollection<Warehouse> products);
    Task UpdateAsync(WarehouseDbContext dbContext, ICollection<Warehouse> products);
    Task DeleteAsync(WarehouseDbContext dbContext, ICollection<long> ids);
}