using WarehouseService.Data.Domain;

namespace WarehouseService.Interfaces;

public interface IProductService
{
    Task<ICollection<Product>> GetAsync();
    Task CreateAsync(ICollection<Product> products);
    Task UpdateAsync(ICollection<Product> products);
    Task DeleteAsync(ICollection<long> ids);
}