using ejHome.AutomationFramework.DriverClass;
using OpenQA.Selenium;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;

namespace ejHome.SpecFlow.Support.BaseStep
{
    [Binding]
    public sealed class Act
    {
        public static IWebDriver browserInstance;

        internal static string Environment => ConfigurationManager.AppSettings["Host"];
        public static string EJ_HomePage_Eng => Environment + ConfigurationManager.AppSettings["EJ_HomePage_Eng"];
        public static string EJ_HomePage_Fr => Environment + ConfigurationManager.AppSettings["EJ_HomePage_Fr"];



        [BeforeScenario]
        public static void beforeEachTest()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("no_browser")){
                if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Firefox")){
                    browserInstance = Driver.InitializeFireFox();
                }else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("InternetExplorer")){
                    browserInstance = Driver.InitializeInternetExplorer();
                }else{
                    browserInstance = Driver.InitializeChrome();
                }
                browserInstance.Navigate().GoToUrl(EJ_HomePage_Eng);
            }
        }

        [AfterScenario]
        public static void afterEachTest()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("no_browser"))
            {
                browserInstance.Quit();
            }
        }
    }
}
