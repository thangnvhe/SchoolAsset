using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.PresentLayer.Areas.Customer.Controllers;

[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Introduce()
    {
        return View();
    }
    public IActionResult Major()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
