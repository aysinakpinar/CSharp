namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

public class AuthTests : PageTest
{
    [Test]
public async Task SigningInWithCorrectCredentials()
    {
        // we need to create a user first
        // you might need to tweak this to work with your sign-up form
        await Page.GotoAsync("http://localhost:5133/Users/New");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByLabel("Username").FillAsync("username");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // signing in - will fail initially!
        await Page.GotoAsync("http://localhost:5133/Sessions/New");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // you will need to update `Spaces/Index` to make this pass
        string pageTitle = await Page.TitleAsync();
        Console.WriteLine($"Current Page Title: {pageTitle}");

        // Assert that the page title matches the expected value (direct comparison with string)
        Assert.That(pageTitle, Is.EqualTo("Spaces - MakersBnB"));
    }

    [Test]
    public async Task SigningInWithInCorrectCredentials()
    {
        // we need to create a user first
        // you might need to tweak this to work with your sign-up form
        await Page.GotoAsync("http://localhost:5133/Users/New");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByLabel("Username").FillAsync("username");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // signing in - will fail initially!
        await Page.GotoAsync("http://localhost:5133/Sessions/New");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByLabel("Password").FillAsync("new_secret");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // you will need to update `Spaces/Index` to make this pass
        string pageTitle = await Page.TitleAsync();
        Console.WriteLine($"Current Page Title: {pageTitle}");

        // Assert that the page title matches the expected value (direct comparison with string)
        Assert.That(pageTitle, Is.EqualTo("Sign in - MakersBnB"));
    }
    
[Test]
public async Task SigningInWithInNoUsers()
    {
        // we need to create a user first
        // you might need to tweak this to work with your sign-up form
        await Page.GotoAsync("http://localhost:5133/Users/New");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByLabel("Username").FillAsync("username");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // signing in - will fail initially!
        await Page.GotoAsync("http://localhost:5133/Sessions/New");
        await Page.GetByLabel("Email").FillAsync("example@email.com");
        await Page.GetByLabel("Password").FillAsync("new_secret");
        await Page.GetByRole(AriaRole.Button).ClickAsync();

        // you will need to update `Spaces/Index` to make this pass
        string pageTitle = await Page.TitleAsync();
        Console.WriteLine($"Current Page Title: {pageTitle}");

        // Assert that the page title matches the expected value (direct comparison with string)
        Assert.That(pageTitle, Is.EqualTo("Sign in - MakersBnB"));
    }
}
