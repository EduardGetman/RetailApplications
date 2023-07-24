namespace WarehouseWebService.Data.Domain;

/// <summary>
/// Сущность "Склад"
/// </summary>
public class Warehouse : DomainBase
{
    public string Code { get; set; }
    public string Adress { get; set; }
    public ICollection<Shipment> Shipments { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
    public ICollection<ProductStock> ProductStocks { get; set; }
}