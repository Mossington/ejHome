using ejHome.AutomationFramework.Selenium.ScreenActions;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.SpecFlow.Support.SpoPattern
{
    public class SpoErrors
    {
        //Static Content
        readonly public static StaticContent error404 = new StaticContent(SelectBy.Class, "page-header-2");
    }
}
