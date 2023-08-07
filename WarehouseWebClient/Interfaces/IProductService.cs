using WarehouseWebClient.Models;

namespace WarehouseWebClient.Interfaces;

public interface IProductService
{
    ProductsModel GetProductsModel(int pageIndex, int pageSize);
}