using ejHome.AutomationFramework.Selenium.ScreenActions;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.SpecFlow.Support.SpoPattern
{
    public class SpoHomePage
    {
        //Buttons
        readonly public static Button SignIn = new Button(SelectBy.Class, "sign-in");
        readonly public static Button SignOut = new Button(SelectBy.Class, "sign-out");
        readonly public static Button OutboundFlightPicker = new Button(SelectBy.Class, "outbound-date-picker");
        readonly public static Button ReturnFlightPicker = new Button(SelectBy.Class, "return-date-picker");
        readonly public static Button ShowFlights = new Button(SelectBy.Class, "search-submit");

        //Text Fields
        readonly public static TextField FlightsFrom = new TextField(SelectBy.Name, "origin");
        readonly public static TextField FlightsTo = new TextField(SelectBy.Name, "destination");
    }
}
