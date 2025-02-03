namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Tests : PageTest
{
    // the following method is a test
    [Test]
    public async Task IndexpageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        // go to the MakersBnB Index page
        await Page.GotoAsync("http://localhost:5133");

        // expect the page title to contain "Index Page - MakersBnB"
        await Expect(Page).ToHaveTitleAsync(new Regex("Home Page - MakersBnB"));
    }
    [Test]
    public async Task HomePageIncludesWelcomeMessage() {
    await Page.GotoAsync("http://localhost:5133");

    await Expect(Page.GetByText("Welcome to MakersBnB!")).ToBeVisibleAsync();
    }
    [Test]
    public async Task ReviewsIncludedInThePage()
    {
        await Page.GotoAsync("http://localhost:5133");
        string[] expectedReviews = 
        {
            "a five star accommodation", "very clean", "lovely staff", "great location"
        };

        var reviewElements = await Page.Locator("ol li").AllTextContentsAsync();
        foreach (var review in reviewElements)
            {
                Assert.That(expectedReviews, Does.Contain(review));
            }
    }
    [Test]
    public async Task PrivacyPageTitle()
    {
        await Page.GotoAsync("http://localhost:5133/Home/Privacy");
        await Expect(Page).ToHaveTitleAsync(new Regex("Privacy Policy"));
    }
    [Test]
    public async Task PrivacyPageContentsEffectiveDate()
    {
        await Page.GotoAsync("http://localhost:5133/Home/Privacy");
        await Expect(Page.GetByText("Effective Date: 3 February 2025")).ToBeVisibleAsync();
    }
    [Test]
    public async Task PrivacyPageInformationWeCollect()
    {
        await Page.GotoAsync("http://localhost:5133/Home/Privacy");
        string [] expectedInformationCollected = 
        {"Personal Information: Name, email, phone number (provided voluntarily).", 
        "Non-Personal Information: IP address, browser type, technical data.", 
        "Cookies: Used to enhance user experience and gather analytics."};
        var informationCollected = await Page.Locator("ul li").AllTextContentsAsync();
        foreach(var expectedItem in expectedInformationCollected )
        {
            Assert.That(informationCollected, Does.Contain(expectedItem));
        }
    }
}