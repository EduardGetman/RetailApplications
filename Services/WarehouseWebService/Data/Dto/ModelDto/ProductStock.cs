﻿namespace WarehouseWebService.Data.Dto.ModelDto;

/// <summary>
/// Сущность "Запас Товара"
/// </summary>
public class ProductStock : ModelDtoBase
{
    public decimal Volume { get; set; }
}