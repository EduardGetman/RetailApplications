using Microsoft.EntityFrameworkCore;
using WarehouseService.Data.Domain;
using WarehouseService.Infrastructure;
using WarehouseService.Interfaces;

namespace WarehouseService.Application.Services;

public class ProductService : IProductService
{
    private readonly WarehouseDbContext _dbContext;

    public ProductService(WarehouseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<Product>> GetAsync()
    {
        return await _dbContext.Products.AsNoTracking().ToArrayAsync();
    }

    public async Task CreateAsync(ICollection<Product> products)
    {
        await _dbContext.AddRangeAsync(products);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(ICollection<Product> products)
    {
        _dbContext.Products.UpdateRange(products);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(ICollection<long> ids)
    {
        var toRemove = _dbContext.Products.Where(x=> x.Id.HasValue && ids.Contains(x.Id.Value));
        _dbContext.Products.RemoveRange(toRemove);
        await _dbContext.SaveChangesAsync();
    }
}