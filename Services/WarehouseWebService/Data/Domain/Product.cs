﻿using WarehouseWebService.Common.Enums;

namespace WarehouseWebService.Data.Domain;

/// <summary>
/// Сущность "Товар"
/// </summary>
public class Product : DomainBase
{
    public string Name { get; set; }
    public string Code { get; set; }
    public MeasurementUnitsKind MeasurementUnits { get; set; }
    public ICollection<ProductStock> ProductStocks { get; set; }
    public ICollection<Shipment> Shipments { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
}