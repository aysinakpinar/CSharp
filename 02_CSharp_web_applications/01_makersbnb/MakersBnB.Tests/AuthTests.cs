namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

public class AuthTests : PageTest
{
    [Test]
    public void SigningInWithCorrectCredentials()
    {
        // we need to create a user first
        // you might need to tweak this to work with your sign up form
        Page.GotoAsync("http://localhost:5106/Users/New");
        Page.GetByLabel("Password").FillAsync("secret");
        Page.GetByLabel("Username").FillAsync("username");
        Page.GetByLabel("Email").FillAsync("email@email.com");
        Page.GetByRole(AriaRole.Button).ClickAsync();

        // signing in - will fail initially!
        Page.GotoAsync("http://localhost:5106/Sessions/New");
        Page.GetByLabel("Email").FillAsync("email@email.com");
        Page.GetByLabel("Password").FillAsync("secret");
        Page.GetByRole(AriaRole.Button).ClickAsync();

        // you will need to update `Spaces/Index` to make this pass
        Expect(Page).ToHaveTitleAsync(new Regex("Spaces - MakersBnB"));

    }
}
