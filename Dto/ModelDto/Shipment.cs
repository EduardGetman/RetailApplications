namespace Dto.ModelDto;

/// <summary>
/// Сущность "Отгрузка"
/// </summary>
public class Shipment : ModelDtoBase
{
    public decimal Volume { get; set; }
    public DateTime DateTime { get; set; }
}