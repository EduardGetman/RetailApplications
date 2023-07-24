using Microsoft.EntityFrameworkCore;
using WarehouseWebService.Data.Domain;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;
using WarehouseWebService.Interfaces;

namespace WarehouseWebService.Application.Services;

public class ProductService : IProductService
{
    public async Task<ICollection<Product>> GetAsync(WarehouseDbContext dbContext)
    {
        return await dbContext.Products.AsNoTracking().ToArrayAsync();
    }

    public async Task CreateAsync(WarehouseDbContext dbContext, ICollection<Product> products)
    {
        await dbContext.AddRangeAsync(products);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(WarehouseDbContext dbContext, ICollection<Product> products)
    {
        dbContext.Products.UpdateRange(products);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(WarehouseDbContext dbContext, ICollection<long> ids)
    {
        var toRemove = dbContext.Products.Where(x=> x.Id.HasValue && ids.Contains(x.Id.Value));
        dbContext.Products.RemoveRange(toRemove);
        await dbContext.SaveChangesAsync();
    }
}