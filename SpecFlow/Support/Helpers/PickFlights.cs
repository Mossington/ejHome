using ejHome.SpecFlow.Support.BaseStep;
using ejHome.SpecFlow.Support.SpoPattern;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace ejHome.SpecFlow.Support.Helpers
{
    public class PickFlights
    {
        public static void OutboundFlight(string outboundFlightDate)
        {
            Flight(outboundFlightDate);
        }

        public static void ReturnFlight(string returnFlightDate)
        {
            Flight(returnFlightDate);
        }

        public static void Continue()
        {
            SpoHelpingHand.Continue.Click();
        }

        public static void Flight(string OutboundInbound)
        {
            ICollection<IWebElement> FlightDays = Act.browserInstance.FindElements(By.ClassName("flight-grid-day-wrapper"));
            foreach (var item in FlightDays)
            {
                if (item.Text.Contains(OutboundInbound)){
                    item.FindElements(By.ClassName("flight-grid-flight-body"))[0].Click();
                    break;
                }
            }
        }
        /// <summary>
        /// outboundFlightDate = string date of the departing flight "1 Sep"
        /// returnFlightDate = string date of the return flight "8 Sep"
        /// note, the month is 3 characters long
        /// </summary>
        /// <param name="outboundFlightDate"></param>
        /// <param name="returnFlightDate"></param>

        public static void HappyPath(string outboundFlightDate, string returnFlightDate)
        {
            OutboundFlight(outboundFlightDate);
            ReturnFlight(returnFlightDate);
            Continue();
        }
    }
}
