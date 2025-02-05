using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class UsersController : Controller
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult New()
    {
        return View();
    }

    [Route("/Users")]
    [HttpPost]
    public IActionResult Create(User user)
    {   
        MakersBnBDbContext dbContext = new MakersBnBDbContext();
        // Here's where we finally use the dbContext
        dbContext?.Users?.Add(user);
        dbContext?.SaveChanges();

        // redirect to "/Spaces"
        return new RedirectResult("/Spaces");
    }
}