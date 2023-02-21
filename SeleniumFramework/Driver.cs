using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            //options.AddArgument("window-size=800,600");
            //options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            // Su refresh
            driver.Url = url;

            // Be refresh, išlaikom veiksmus kurie galėjo būti atlikti svetainėje
            //driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
