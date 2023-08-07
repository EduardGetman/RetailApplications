using WarehouseWebClient.Interfaces;
using WarehouseWebClient.Models;
using WarehouseWebClient.Models.Entity;

namespace WarehouseWebClient.Services;

public class WarehouseService : IWarehouseService
{
    public WarehousesModel GetWarehousesModel(int pageIndex, int pageSize)
    {
        var products = new WarehouseEntity[]
        {
            new()
            {
                Id = 1,
                Code = "2000001",
                Adress = "улица Гагарина, 106, Липецк",
            },
            new()
            {
                Id = 2,
                Code = "2000002",
                Adress = "проспект имени 60-летия СССР, 47, Липецк",
            },
            new ()
            {
                Id = 3,
                Code = "2000003",
                Adress = "улица Катукова, 29, Липецк",
            },
        };
        return new WarehousesModel(pageIndex * pageSize, products);
    }
    
    public WarehousesModel GetWarehouseRemainsModel(int pageIndex, int pageSize)
    {
        var products = new WarehouseEntity[]
        {
            new()
            {
                Id = 1,
                Code = "2000001",
                Adress = "улица Гагарина, 106, Липецк",
            },
            new()
            {
                Id = 2,
                Code = "2000002",
                Adress = "проспект имени 60-летия СССР, 47, Липецк",
            },
            new ()
            {
                Id = 3,
                Code = "2000003",
                Adress = "улица Катукова, 29, Липецк",
            },
        };
        return new WarehousesModel(pageIndex * pageSize, products);
    }
}