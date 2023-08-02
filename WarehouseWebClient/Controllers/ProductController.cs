using Microsoft.AspNetCore.Mvc;

namespace WarehouseWebClient.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
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