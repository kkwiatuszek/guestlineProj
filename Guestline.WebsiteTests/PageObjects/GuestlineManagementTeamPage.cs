using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Guestline.WebsiteTests.PageObjects
{
    public class GuestlineManagementTeamPage
    {
        public bool IsCorrectNameDisplayedForJobTitle(string name, string jobTitle)
        {
            return Directors.Any(d => d.FullName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                                      d.JobTitle.Equals(jobTitle, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Director> Directors =>
            Browser.Driver.FindElements(By.CssSelector(".peopleContent")).Select(e => new Director(e));
    }

    public class Director
    {
        private readonly IWebElement _element;

        public Director(IWebElement element)
        {
            _element = element;
        }

        public string FullName => _element.FindElement(By.CssSelector("h2")).Text;
        public string JobTitle => _element.FindElement(By.CssSelector("h3")).Text;
    }
}
