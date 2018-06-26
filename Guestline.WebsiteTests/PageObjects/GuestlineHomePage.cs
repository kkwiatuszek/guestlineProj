using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace Guestline.WebsiteTests.PageObjects
{
    public class GuestlineHomePage
    {
        public string HomePageUrl = "https://www.guestline.com/";

        [FindsBy(How = How.CssSelector, Using = ".navbar-brand")]
        public IWebElement _companyLogo;

        [FindsBy(How = How.CssSelector, Using = "[href='https://www.guestline.com/about-us.html']")]
        private IWebElement _aboutUsDropdown;

        [FindsBy(How = How.CssSelector, Using = "[href*='management-team']")]
        private IWebElement _managementTeamButton;


        public void HoverOverAboutUsDropdown()
        {
            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(_aboutUsDropdown).Perform();
        }

        public void OpenManagementTeamLink()
        {
            _managementTeamButton.Click();
        }

        public bool IsGuestlineLogoVisible()
        {
            return Browser.IsVisible(_companyLogo);
        }

    }
}
