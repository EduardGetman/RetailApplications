namespace Dto.ModelDto;

/// <summary>
/// Сущность "Поставка"
/// </summary>
public class Delivery : ModelDtoBase
{
    public decimal Volume { get; set; }
    public DateTime DateTime { get; set; }
}