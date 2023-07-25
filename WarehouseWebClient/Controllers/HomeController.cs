using Microsoft.AspNetCore.Mvc;

namespace WarehouseWebClient.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}