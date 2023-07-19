using WarehouseService.Data.Domain;

namespace WarehouseService.Interfaces;

public interface IWarehouseService
{
    Task<ICollection<Warehouse>> GetAsync();
    Task CreateAsync(ICollection<Warehouse> products);
    Task UpdateAsync(ICollection<Warehouse> products);
    Task DeleteAsync(ICollection<long> ids);
}