using ejHome.AutomationFramework.Selenium.ScreenActions;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.SpecFlow.Support.SpoPattern
{
    public class SpoLogin
    {
        //Buttons
        readonly public static Button SignIn = new Button(SelectBy.Id, "signin-login");

        //Test Fields
        readonly public static TextField Username = new TextField(SelectBy.Id, "signin-username");
        readonly public static TextField Password = new TextField(SelectBy.Id, "signin-password");
    }
}
