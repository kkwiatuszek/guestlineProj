using OpenQA.Selenium.Support.PageObjects;

namespace Guestline.WebsiteTests.PageObjects
{
   public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static GooglePage GooglePage => GetPage<GooglePage>();
        public static GuestlineHomePage GuestlineHomePage => GetPage<GuestlineHomePage>();
        public static GuestlineManagementTeamPage GuestlineManagementTeamPage => GetPage<GuestlineManagementTeamPage>();
    }
}
