using Microsoft.EntityFrameworkCore;
using WarehouseService.Data.Domain;
using WarehouseService.Infrastructure;
using WarehouseService.Interfaces;

namespace WarehouseService.Application.Services;

public class WarehouseService : IWarehouseService
{
    private readonly WarehouseDbContext _dbContext;

    public WarehouseService(WarehouseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<Warehouse>> GetAsync()
    {
        return await _dbContext.Warehouses.AsNoTracking().ToArrayAsync();
    }

    public async Task CreateAsync(ICollection<Warehouse> products)
    {
        await _dbContext.AddRangeAsync(products);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(ICollection<Warehouse> products)
    {
        _dbContext.Warehouses.UpdateRange(products);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(ICollection<long> ids)
    {
        var toRemove = _dbContext.Warehouses.Where(x=> x.Id.HasValue && ids.Contains(x.Id.Value));
        _dbContext.Warehouses.RemoveRange(toRemove);
        await _dbContext.SaveChangesAsync();
    }
}