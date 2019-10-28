using ejHome.AutomationFramework.Selenium.ScreenActions;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.SpecFlow.Support.SpoPattern
{
    public class SpoHelpingHand
    {
        readonly public static Button Continue = new Button(SelectBy.CssSelector, "div.helping-hand > div > div > div > div.button-container");
        readonly public static Button Skip = new Button(SelectBy.CssSelector, "div.helping-hand > div > div > div > div.link-container > button");
    }
}
