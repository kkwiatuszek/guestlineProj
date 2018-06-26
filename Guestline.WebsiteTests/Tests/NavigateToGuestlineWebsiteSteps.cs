using Guestline.WebsiteTests.PageObjects;
using Shouldly;
using TechTalk.SpecFlow;

namespace Guestline.WebsiteTests
{
    [Binding]
    public class NavigateToGuestlineWebsiteSteps
    {
        [Given(@"I navigate to google home page")]
        public void GivenINavigateToGoogleHomePage()
        {
            Browser.NavigateTo(Pages.GooglePage.GoogleUrl);
        }
        
        [Given(@"I search for Guestline")]
        public void GivenISearchForGuestline()
        {
            Pages.GooglePage.SearchFor("Guestline");
        }
        [When(@"I open the Guestline home page result")]
        public void WhenIOpenTheGuestlineHomePageResult()
        {
            Pages.GooglePage.OpenResultForGuestline();
        }

        [Then(@"I land on Guestline's website home page")]
        public void ThenILandOnGuestlineSWebsiteHomePage()
        {
            Browser.IsUrlCorrect(Pages.GuestlineHomePage.HomePageUrl).ShouldBe(true);
            Pages.GuestlineHomePage.IsGuestlineLogoVisible().ShouldBe(true);
        }
        
        [Then(@"I can navigate back to google")]
        public void ThenICanNavigateBackToGoogle()
        {
            Browser.NavigateTo(Pages.GooglePage.GoogleUrl);
            Browser.IsUrlCorrect(Pages.GooglePage.GoogleUrl);
        }
    }
}
