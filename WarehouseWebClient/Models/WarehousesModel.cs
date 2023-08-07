using WarehouseWebClient.Models.Entity;

namespace WarehouseWebClient.Models;

public class WarehousesModel
{
    public int FirstEntityNumber { get; set; }
    public List<WarehouseEntity> Warehouses { get; set; }

    public WarehousesModel(int firstEntityNumber, IEnumerable<WarehouseEntity> warehouses)
    {
        FirstEntityNumber = firstEntityNumber;
        Warehouses = warehouses.ToList();
    }
}