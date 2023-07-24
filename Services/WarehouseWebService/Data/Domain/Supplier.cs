namespace WarehouseWebService.Data.Domain;

/// <summary>
/// Сущность "Поставщик"
/// </summary>
public class Supplier : DomainBase
{
    public string Code { get; set; }
    public string Name { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
}