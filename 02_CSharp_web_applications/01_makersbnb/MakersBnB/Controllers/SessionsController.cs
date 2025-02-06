using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;
using Microsoft.AspNetCore.Identity;
using MakersBnB.ActionFilters;


namespace MakersBnB.Controllers;

public class SessionsController : Controller
{
    private readonly ILogger<SessionsController> _logger;

    public SessionsController(ILogger<SessionsController> logger)
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


    [Route("/Sessions")]
    [HttpPost]
    public IActionResult LogIn(string email, string password)
    {  
        // ASP.NET automatically passes email and password as args (see above)

    MakersBnBDbContext dbContext = new MakersBnBDbContext();

    // using the submitted email to find a user in the database
    User? user = dbContext?.Users?.FirstOrDefault(u => u.Email == email);

    // checking if a user was found and that the passwords match
    if(user != null)
        {
            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.Password ?? "", password);
            if (result == PasswordVerificationResult.Success)
            {
            // putting the user's id in their session for later
                HttpContext.Session.SetInt32("user_id", user.Id);
                return new RedirectResult("/Sessions/Dashboard");
            }
            else
            {
                TempData["ErrorMessage"] = "Incorrect password. Please try again.";
                return RedirectToAction("New"); // Redirect back to login
            }
        } 
    TempData["ErrorMessage"] = $"There isn't any account for {email}. Please sign up.";
    return RedirectToAction("New"); // Redirect back to login
    }
    [ServiceFilter(typeof(AuthenticationFilter))]
    public IActionResult Dashboard()
    {
        MakersBnBDbContext dbContext = new MakersBnBDbContext();

        int? userId =  HttpContext.Session.GetInt32("user_id");
        User? user = dbContext?.Users?.FirstOrDefault(u => u.Id == userId);
        ViewBag.User = user;
        // ViewBag.UserName = user.UserName; // Pass data to the view
        return View();
    }
    public IActionResult Logout()
    {
        HttpContext.Session.Clear(); // Removes all session data
        return RedirectToAction("Index", "Home");
    }
}