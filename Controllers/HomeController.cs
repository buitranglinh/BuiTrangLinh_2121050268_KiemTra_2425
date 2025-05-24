using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KiemTraMVC.Models;

namespace KiemTraMVC.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Errors()
    {
        return View(new ErrorViewModel { RequestId = EventActivityOptions.Curent?.Id ?? HttpContext.TraceIdentifier });
    }
}