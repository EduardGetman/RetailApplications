namespace WarehouseService.Data.Dto.ModelDto;

/// <summary>
/// Сущность "Склад"
/// </summary>
public class Warehouse : ModelDtoBase
{
    public string Code { get; set; }
    public string Adress { get; set; }
    public ICollection<Shipment> Shipments { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
    public ICollection<ProductStock> ProductStocks { get; set; }
}