using WarehouseWebClient.Models.Entity;

namespace WarehouseWebClient.Models;

public class ProductsModel
{
    public int FirstEntityNumber { get; set; }
    public List<ProductEntity> Products { get; set; }

    public ProductsModel(int firstEntityNumber, IEnumerable<ProductEntity> products)
    {
        FirstEntityNumber = firstEntityNumber;
        Products = products.ToList();
    }
}