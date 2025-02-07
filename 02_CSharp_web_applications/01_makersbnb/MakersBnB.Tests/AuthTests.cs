using Bogus;  // Import the Bogus namespace
using System.Text.RegularExpressions;
using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace MakersBnB.Tests
{
    [TestFixture]
    public class AuthTests : PageTest
    {
        private Bogus.Faker _faker;  // Declare Faker as a Bogus Faker
        private CustomPasswordGenerator _passwordGenerator;

        [SetUp]
        public void SetUp()
        {
            _faker = new Bogus.Faker();  // Instantiate Bogus Faker
            _passwordGenerator = new CustomPasswordGenerator();
        }

        [Test]
        public async Task SigningInWithCorrectCredentials()
        {
            // Generate random valid password with the custom rules
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            
            // You need to create a user first
            // You might need to tweak this to work with your sign-up form
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Signing in - will fail initially!
            await Page.GotoAsync("http://localhost:5133/Sessions/New");
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // You will need to update `Spaces/Index` to make this pass
            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");

            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Dashboard - MakersBnB"));
        }

        [Test]
        public async Task SigningInWithInCorrectCredentials()
        {
            // Generate random valid password with the custom rules
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            var incorrectPassword = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Signing in - will fail initially!
            await Page.GotoAsync("http://localhost:5133/Sessions/New");
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(incorrectPassword);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");

            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Sign In - MakersBnB"));
        }

        [Test]
        public async Task SigningInWithInCorrectCredentialsShowsErrorMessage()
        {
            // Generate random valid password with the custom rules
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            var incorrectPassword = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Signing in - will fail initially!
            await Page.GotoAsync("http://localhost:5133/Sessions/New");
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(incorrectPassword);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Sessions/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Incorrect password. Please try again."));
        }

        [Test]
        public async Task SigningInWithNoUserEmail()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            var newUserEmail = _faker.Internet.Email();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Signing in - will fail initially!
            await Page.GotoAsync("http://localhost:5133/Sessions/New");
            await Page.GetByLabel("Email").FillAsync(newUserEmail);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");

            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Sign In - MakersBnB"));
        }
        [Test]
        public async Task SigningInWithNoUserEmailShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            var newUserEmail = _faker.Internet.Email();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Signing in - will fail initially!
            await Page.GotoAsync("http://localhost:5133/Sessions/New");
            await Page.GetByLabel("Email").FillAsync(newUserEmail);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Sessions/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo($"There is not any account for {newUserEmail}. Please sign up."));
        }

        [Test]
        public async Task SignUpCorrectRules()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();
            string currentUrl = Page.Url;
            Console.WriteLine($"📌 Current URL: {currentUrl}"); 
            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");

            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Sign In - MakersBnB"));
        }
        [Test]
        public async Task SignUpWithEmptyUserNameShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            var username = "";
            var password = "Test1234!";

            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Check if the current URL is the expected URL after the redirect
            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Username can not be empty. Please try again."));
        }
        [Test]
        public async Task SignUpWithEmptyPasswordShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = "";

            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Check if the current URL is the expected URL after the redirect
            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Password can not be empty. Please try again."));
        }
        public async Task SignUpWithEmptyEmailShowsErrorMessage()
        {
            var email = "";
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword();

            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Check if the current URL is the expected URL after the redirect
            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Email can not be empty. Please try again."));
        }

        [Test]
        public async Task SignUpWithShortUserNamePageTitle()
        {
            var email = _faker.Internet.Email();
            string shortUsername = _faker.Lorem.Letter(2);
            var password = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(shortUsername);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");
            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Sign Up - MakersBnB"));
        }
        [Test]
        public async Task SignUpWithShortUserNameShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            string shortUsername = _faker.Lorem.Letter(2);
            var password = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(shortUsername);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Username can not be shorter than 3 characters. Please try again."));
        }
        [Test]
        public async Task SignUpWithASpaceInUsernameShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            string username = "Test username";
            var password = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Username can not have a space. Please try again."));
        }
        [Test]
        public async Task SignUpWithAUserNameHasSpecialCharsShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            string username = "Test%username";
            var password = _passwordGenerator.GeneratePassword();
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Username should only contain letters, numbers or underscore. Please try again."));
        }
        [Test]
        public async Task SignUpWithAPasswordNotInTheRulesShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            string username = _faker.Internet.UserName();
            var password = "Test1234";
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Password should contain at least one lower case, one upper case, one number and one of the special characters '_$!*&.'. Please try again."));
        }

        [Test]
        public async Task SignUpWithAPreviousUsername()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            // Sign-up might fail if username already exists
            string pageTitle = await Page.TitleAsync();
            Console.WriteLine($"Current Page Title: {pageTitle}");

            // Assert that the page title matches the expected value (direct comparison with string)
            Assert.That(pageTitle, Is.EqualTo("Sign Up - MakersBnB"));
        }
        [Test]
        public async Task SignUpWithAPreviousUsernameShowsErrorMessage()
        {
            var email = _faker.Internet.Email();
            var username = _faker.Internet.UserName();
            var password = _passwordGenerator.GeneratePassword(); // Get the password that meets the rules
            // We need to create a user first
            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            await Page.GotoAsync("http://localhost:5133/Users/New");
            await Page.GetByLabel("Password").FillAsync(password);
            await Page.GetByLabel("Username").FillAsync(username);
            await Page.GetByLabel("Email").FillAsync(email);
            await Page.GetByRole(AriaRole.Button).ClickAsync();

            Assert.That(Page.Url, Is.EqualTo("http://localhost:5133/Users/New"));

            var errorMessageLocator = Page.Locator(".alert.alert-danger");
            await errorMessageLocator.WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
            var errorMessage = await errorMessageLocator.TextContentAsync() ?? "Default Message";
            var trimmedErrorMessage = errorMessage.Trim();
            Assert.That(trimmedErrorMessage, Is.EqualTo("Username already taken. Please choose a different one."));
        }
    }
}
