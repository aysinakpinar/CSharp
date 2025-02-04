using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class SpacesController : Controller
{
    private readonly ILogger<SpacesController> _logger;

    public SpacesController(ILogger<SpacesController> logger)
    {
        _logger = logger;
    }

    // will handle `GET "/Spaces"`
    public IActionResult Index()
    {
        MakersBnBDbContext dbContext = new MakersBnBDbContext();
        var spaces = dbContext?.Spaces?.ToList();
        ViewBag.Spaces = spaces;
        // will try to find Spaces.cshtml in Views/Spaces or Views/Shared
        return View();
    }
    public IActionResult New()
    {
        return View();
    }
    // In this case we need a custom route mapping
// we also need to specify that we're handling a POST request
// to differentiate from Index(), which handles 'GET "/spaces"'
[Route("/Spaces")]
[HttpPost]
public IActionResult Create(Space space)
{   
    MakersBnBDbContext dbContext = new MakersBnBDbContext();
    // Here's where we finally use the dbContext
    dbContext.Spaces.Add(space);
    dbContext.SaveChanges();

    // redirect to "/Spaces"
    return new RedirectResult("/Spaces");
}

}
