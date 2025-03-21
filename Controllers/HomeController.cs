using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EsmaGida.Models;

namespace EsmaGida.Controllers;

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

    public IActionResult login()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult forgotpass()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
