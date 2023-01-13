using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc101.Models;

namespace mvc101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = {"Mon", "Tue", "Wed", "Thur", "Sat", "Sun"};
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Bogus() 
    {
        string[] days = {"Mon", "Tue", "Wed", "Thur", "Sat", "Sun"};
        ViewData["author"] = "Jane doe";
        ViewBag.Date = DateTime.Now;

        return View(days);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
