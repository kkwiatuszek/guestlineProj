using Guestline.WebsiteTests.PageObjects;
using Shouldly;
using TechTalk.SpecFlow;

namespace Guestline.WebsiteTests
{
    [Binding]
    public class DisplaySeniorTeamMembersInformationSteps
    {
        [Given(@"I navigate to Guestline's website")]
        public void GivenINavigateToGuestlineSWebsite()
        {
            Browser.NavigateTo(Pages.GuestlineHomePage.HomePageUrl);
        }
        
        [When(@"I go to the management team page")]
        public void WhenIGoToTheManagementTeamPage()
        {
            Pages.GuestlineHomePage.HoverOverAboutUsDropdown();
            Pages.GuestlineHomePage.OpenManagementTeamLink();
        }
        
        [Then(@"I can see that Guestline's CEO is Andrew McGregor")]
        public void ThenICanSeeThatGuestlineSCEOIsAndrewMcGregor()
        {
            Pages.GuestlineManagementTeamPage.IsCorrectNameDisplayedForJobTitle("Andrew McGregor", "CEO").ShouldBe(true);
        }

    }
}
