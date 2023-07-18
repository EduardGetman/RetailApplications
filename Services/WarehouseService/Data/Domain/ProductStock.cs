namespace WarehouseService.Data.Domain;

/// <summary>
/// Сущность "Запас Товара"
/// </summary>
public class ProductStock : DomainBase
{
    public decimal Volume { get; set; }
    public Product Product { get; set; }
    public Warehouse Warehouse { get; set; }
}