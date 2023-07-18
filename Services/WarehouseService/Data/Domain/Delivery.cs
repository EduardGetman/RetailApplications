namespace WarehouseService.Data.Domain;

/// <summary>
/// Сущность "Поставка"
/// </summary>
public class Delivery : DomainBase
{
    public decimal Volume { get; set; }
    public DateTime DateTime { get; set; }
    public Warehouse Destination { get; set; }
    public Supplier Supplier { get; set; }
    public Product Product { get; set; }
}