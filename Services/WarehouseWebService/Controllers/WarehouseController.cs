using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WarehouseWebService.Data.Dto.ModelDto;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;
using WarehouseWebService.Interfaces;

namespace WarehouseWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;
    private readonly IMapper _mapper;
    private readonly WarehouseDbContext _dbContext;

    public WarehouseController(IWarehouseService warehouseService, IMapper mapper, WarehouseDbContext dbContext)
    {
        _warehouseService = warehouseService;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            var domain = await _warehouseService.GetAsync(_dbContext);
            return Ok(_mapper.Map<List<Warehouse>>(domain));
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }

    [HttpPost]
    public async Task<ActionResult> Create(ICollection<Warehouse> warehouses)
    {
        try
        {
            var domain = _mapper.Map<List<Data.Domain.Warehouse>>(warehouses);
            await _warehouseService.CreateAsync(_dbContext, domain);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }

    [HttpPut]
    public async Task<ActionResult> Update(ICollection<Warehouse> warehouses)
    {
        try
        {
            var domain = _mapper.Map<List<Data.Domain.Warehouse>>(warehouses);
            await _warehouseService.UpdateAsync(_dbContext, domain);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }
    [HttpDelete]
    public async Task<ActionResult> Delete(ICollection<long> ids)
    {
        try
        {
            await _warehouseService.DeleteAsync(_dbContext, ids);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }
}