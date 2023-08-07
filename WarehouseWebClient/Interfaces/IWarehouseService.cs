using WarehouseWebClient.Models;

namespace WarehouseWebClient.Interfaces;

public interface IWarehouseService
{
    WarehousesModel GetWarehousesModel(int pageIndex, int pageSize);
}