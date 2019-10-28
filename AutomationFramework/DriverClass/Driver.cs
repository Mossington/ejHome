using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ejHome.AutomationFramework.DriverClass
{
    public class Driver
    {
        public static IWebDriver instance;

        public static IWebDriver InitializeChrome()
        {
            instance = new ChromeDriver();
            instance.Manage().Window.Maximize();
            return instance;
        }

        public static IWebDriver InitializeFireFox()
        {
            instance = new FirefoxDriver();
            instance.Manage().Window.Maximize();
            return instance;
        }

        public static IWebDriver InitializeInternetExplorer()
        {
            instance = new InternetExplorerDriver();
            instance.Manage().Window.Maximize();
            return instance;
        }

        public static void closeBrowserInstance()
        {
            instance.Quit();
        }
    }
}
