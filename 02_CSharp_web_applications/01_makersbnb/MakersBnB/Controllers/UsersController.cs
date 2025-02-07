using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;


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
    public IActionResult Create(string username, string email, string password)
    {
        MakersBnBDbContext dbContext = new MakersBnBDbContext();

        if(string.IsNullOrEmpty(username))
        {
            TempData["ErrorMessage"] = "Username can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }
        if(password == null)
        {
            TempData["ErrorMessage"] = "Password can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        if(email == null)
        {
            TempData["ErrorMessage"] = "Email can not be empty. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        if(username.Length < 3)
        {
            TempData["ErrorMessage"] = "Username can not be shorter than 3 characters. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        if(username.Contains(" "))
        {
            TempData["ErrorMessage"] = "Username can not have a space. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        Regex rgUserName = new Regex("[^a-zA-Z0-9_.]");
        if(rgUserName.IsMatch(username))
        {
            TempData["ErrorMessage"] = "Username should only contain letters, numbers or underscore. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        Regex rgUpperCase = new Regex("[A-Z]");
        Regex rgLowerCase = new Regex("[a-z]");
        Regex rgNumbers = new Regex("[0-9]");
        Regex rgSpecialChars = new Regex("[-_$!*&.]");
        if(!rgUpperCase.IsMatch(password) ||
        !rgLowerCase.IsMatch(password) ||
        !rgNumbers.IsMatch(password) ||
        !rgSpecialChars.IsMatch(password) ||
        password.Length < 6)
        {
            TempData["ErrorMessage"] = "Password should contain at least one lower case, one upper case, one number and one of the special characters '_$!*&.'. Please try again.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }


        var existingUser = dbContext?.Users?.FirstOrDefault(u => u.UserName == username);
        if (existingUser != null)
        {
            // Flash an error message to the user
            TempData["ErrorMessage"] = "Username already taken. Please choose a different one.";
            return RedirectToAction("New");  // Assuming you redirect back to the registration form
        }

        // Using the default constructor, or you can use the parameterized constructor if you want.
        var newUser = new User
        {
            UserName = username,
            Email = email
        };

        // Use the PasswordHasher to hash the password securely.
        var passwordHasher = new PasswordHasher<User>();
        newUser.Password = passwordHasher.HashPassword(newUser, password);

        // Add the new user to the database.
        dbContext?.Users?.Add(newUser);
        dbContext?.SaveChanges();

        // Redirect to the Spaces Index after the user is created.
        return RedirectToAction("New", "Sessions");
    }
}