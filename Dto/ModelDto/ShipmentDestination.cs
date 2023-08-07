namespace Dto.ModelDto;

/// <summary>
/// Сущность "Пункт назначения отгрузки"
/// </summary>
public class ShipmentDestination : ModelDtoBase
{
    public string Code { get; set; }
    public string Adress { get; set; }
}