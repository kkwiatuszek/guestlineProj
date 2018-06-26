using TechTalk.SpecFlow;

namespace Guestline.WebsiteTests
{
    [Binding]
    public class TestSetup
    {
        [AfterScenario()]
        public static void AfterScenario()
        {
            Browser.Quit();
        }
    }
}
