namespace WarehouseWebClient.Models.Entity;

public class ProductEntity : IdentityEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string MeasurementUnits { get; set; }
    public double Remains { get; set; }
}