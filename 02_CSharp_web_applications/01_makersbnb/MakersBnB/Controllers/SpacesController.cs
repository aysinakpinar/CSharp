using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;
using MakersBnB.ActionFilters;

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

    [ServiceFilter(typeof(AuthenticationFilter))]
    public IActionResult New()
    {
        return View();
    }
    // In this case we need a custom route mapping
    // we also need to specify that we're handling a POST request
    // to differentiate from Index(), which handles 'GET "/spaces"'
    [ServiceFilter(typeof(AuthenticationFilter))]
    [Route("/Spaces")]
    [HttpPost]
    public IActionResult Create(Space space)
    {   
        MakersBnBDbContext dbContext = new MakersBnBDbContext();
        // Here's where we finally use the dbContext
        if(space.Name == null)
        {
            TempData["ErrorMessage"] = "Space name can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }
        if(space.Description== null)
        {
            TempData["ErrorMessage"] = "Space description can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        if(space.Price == null)
        {
            TempData["ErrorMessage"] = "Space Price can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }
        
        if(space.Bedrooms== null)
        {
            TempData["ErrorMessage"] = "Space bedroom number can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        if(space.Rules == null)
        {
            TempData["ErrorMessage"] = "Space rules can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        dbContext?.Spaces?.Add(space);
        dbContext?.SaveChanges();

        // redirect to "/Spaces"
        return new RedirectResult("/Spaces");
    }

}
