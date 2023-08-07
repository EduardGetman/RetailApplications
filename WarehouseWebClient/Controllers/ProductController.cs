using Microsoft.AspNetCore.Mvc;
using WarehouseWebClient.Interfaces;

namespace WarehouseWebClient.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index()
    {
        var model = _productService.GetProductsModel(0, 3);
        return View(model);
    }
    public IActionResult Remains()
    {
        return View();
    }
    public IActionResult Add()
    {
        return StatusCode(501);
    }
    public IActionResult Update()
    {
        return StatusCode(501);
    }
    public IActionResult Remove()
    {
        return StatusCode(501);
    }
}