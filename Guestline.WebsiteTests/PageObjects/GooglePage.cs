using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Guestline.WebsiteTests.PageObjects
{
    public class GooglePage
    {
        public string GoogleUrl = "http://google.co.uk/";

        [FindsBy(How = How.CssSelector, Using = ".lst-c #lst-ib")]
        private IWebElement _searchBox;

        [FindsBy(How = How.CssSelector, Using = ".rc [href='https://www.guestline.com/']")]
        private IWebElement _guestlineSearchResult;

        public void SearchFor(string searchTerm)
        {
            _searchBox.SendKeys(searchTerm);
            _searchBox.SendKeys(Keys.Enter);
        }

        public void OpenResultForGuestline()
        {
            _guestlineSearchResult.Click();
        }
    }
}
