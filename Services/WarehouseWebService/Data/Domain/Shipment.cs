namespace WarehouseWebService.Data.Domain;

/// <summary>
/// Сущность "Отгрузка"
/// </summary>
public class Shipment : DomainBase
{
    public decimal Volume { get; set; }
    public DateTime DateTime { get; set; }
    public Warehouse Source { get; set; }
    public ShipmentDestination Destination { get; set; }
    public Product Product { get; set; }
}