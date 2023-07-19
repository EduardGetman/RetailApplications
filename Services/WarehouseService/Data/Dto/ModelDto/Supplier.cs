namespace WarehouseService.Data.Dto.ModelDto;

/// <summary>
/// Сущность "Поставщик"
/// </summary>
public class Supplier : ModelDtoBase
{
    public string Code { get; set; }
    public string Name { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
}