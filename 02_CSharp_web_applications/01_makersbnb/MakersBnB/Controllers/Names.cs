using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class NamesController : Controller
{
    private readonly ILogger<SpacesController> _logger;

    public NamesController(ILogger<SpacesController> logger)
    {
        _logger = logger;
    }
// controller code
public IActionResult Index()
    {
    // put some names in ViewBag
        ViewBag.Names = new string[2] {"trevor", "pauline"};
        return View();
    }
}