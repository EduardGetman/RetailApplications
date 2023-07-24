using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WarehouseWebService.Data.Dto.ModelDto;
using WarehouseWebService.Infrastructure;
using WarehouseWebService.Infrastructure.Database;
using WarehouseWebService.Interfaces;

namespace WarehouseWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly WarehouseDbContext _dbContext;
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController(IProductService productService, IMapper mapper, WarehouseDbContext dbContext)
    {
        _productService = productService;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            var domain = await _productService.GetAsync(_dbContext);
            return Ok(_mapper.Map<List<Product>>(domain));
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }

    [HttpPost]
    public async Task<ActionResult> Create(ICollection<Product> products)
    {
        try
        {
            var domain = _mapper.Map<List<Data.Domain.Product>>(products);
            await _productService.CreateAsync(_dbContext, domain);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }
    
    [HttpPut]
    public async Task<ActionResult> Update(ICollection<Product> products)
    {
        try
        {
            var domain = _mapper.Map<List<Data.Domain.Product>>(products);
            await _productService.UpdateAsync(_dbContext, domain);
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
            await _productService.DeleteAsync(_dbContext, ids);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }
}