namespace Dto.ModelDto;

/// <summary>
/// Сущность "Товар"
/// </summary>
public class Product : ModelDtoBase
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string MeasurementUnits { get; set; }
    public double TotalRemains { get; set; }
}