using Microsoft.EntityFrameworkCore;
using WarehouseWebService.Data.Domain;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;
using WarehouseWebService.Interfaces;

namespace WarehouseWebService.Application.Services;

public class WarehouseService : IWarehouseService
{

    public async Task<ICollection<Warehouse>> GetAsync(WarehouseDbContext dbContext)
    {
        return await dbContext.Warehouses.AsNoTracking().ToArrayAsync();
    }

    public async Task CreateAsync(WarehouseDbContext dbContext, ICollection<Warehouse> products)
    {
        await dbContext.AddRangeAsync(products);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(WarehouseDbContext dbContext, ICollection<Warehouse> products)
    {
        dbContext.Warehouses.UpdateRange(products);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(WarehouseDbContext dbContext, ICollection<long> ids)
    {
        var toRemove = dbContext.Warehouses.Where(x=> x.Id.HasValue && ids.Contains(x.Id.Value));
        dbContext.Warehouses.RemoveRange(toRemove);
        await dbContext.SaveChangesAsync();
    }
}