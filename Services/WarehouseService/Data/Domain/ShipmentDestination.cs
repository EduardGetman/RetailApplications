namespace WarehouseService.Data.Domain;

/// <summary>
/// Сущность "Пункт назначения отгрузки"
/// </summary>
public class ShipmentDestination : DomainBase
{
    public string Code { get; set; }
    public string Adress { get; set; }
    public ICollection<Shipment> Shipments { get; set; }
}