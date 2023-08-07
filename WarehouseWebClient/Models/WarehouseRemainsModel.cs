using WarehouseWebClient.Models.Entity;

namespace WarehouseWebClient.Models;

public class WarehouseRemainsModel
{
    public int FirstEntityNumber { get; set; }
    public WarehouseEntity Warehouses { get; set; }
    public List<ProductEntity> Products { get; set; }

    public WarehouseRemainsModel(int firstEntityNumber, WarehouseEntity warehouse, IEnumerable<ProductEntity> products)
    {
        FirstEntityNumber = firstEntityNumber;
        Warehouses = warehouse;
        Products = products.ToList();
    }
}