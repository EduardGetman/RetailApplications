using WarehouseWebClient.Interfaces;
using WarehouseWebClient.Models;
using WarehouseWebClient.Models.Entity;

namespace WarehouseWebClient.Services;

public class ProductService : IProductService
{
    public ProductsModel GetProductsModel(int pageIndex, int pageSize)
    {
        var products = new ProductEntity[]
        {
            new ProductEntity()
            {
                Id = 0,
                Code = "1000001",
                MeasurementUnits = "Штука",
                Name = "Coca-cola бутылка 0.5л",
                Remains = 200,
            },
            new ProductEntity()
            {
                Id = 1,
                Code = "1000002",
                MeasurementUnits = "Штука",
                Name = "Coca-cola бутылка 1л",
                Remains = 215,
            },
            new ProductEntity()
            {
                Id = 2,
                Code = "1000003",
                MeasurementUnits = "Штука",
                Name = "Coca-cola бутылка 2л",
                Remains = 80,
            },
        };
        return new ProductsModel(pageIndex * pageSize, products);
    }
}