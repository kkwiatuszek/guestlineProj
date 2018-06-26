using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Guestline.WebsiteTests
{
    public class Browser
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver => _driver ?? (_driver = new ChromeDriver());

        public static void NavigateTo(string url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            if (_driver == null)
                return;

            _driver.Quit();
            _driver = null;
        }

        public static bool IsVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static bool IsUrlCorrect(string url)
        {
            return Driver.Url.Equals(url);
        }
    }
}
