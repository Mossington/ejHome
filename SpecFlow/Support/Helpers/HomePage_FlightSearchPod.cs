using ejHome.SpecFlow.Support.BaseStep;
using ejHome.SpecFlow.Support.SpoPattern;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ejHome.SpecFlow.Support.Helpers
{
    class HomePage_FlightsSearchPod
    {
        public static void OneWay()
        {
            //
        }

        public static void Flights_From(string FlightFrom)
        {
            SpoHomePage.FlightsFrom.value = FlightFrom;
        }

        public static void Flights_To(string FlightTo)
        {
            SpoHomePage.FlightsTo.value = FlightTo;
            SpoHomePage.FlightsFrom.Click();
        }

        public static void Date_RetrunFlight()
        {
            SpoHomePage.OutboundFlightPicker.Click();
            Thread.Sleep(new TimeSpan(0, 0, 2));
            SelectDate();
            SpoHomePage.FlightsFrom.Click();
            SpoHomePage.ReturnFlightPicker.Click();
            Thread.Sleep(new TimeSpan(0, 0, 2));
            SelectDate();
        }

        public static void Date_SingleFlight()
        {
            //
        }

        /// <summary>
        /// This selectDate method can be used for both edparting and retunr dates
        /// This method also uses next month to grab the dates from, with the return date being 7 days after departing date
        /// </summary>
        public static void SelectDate()
        {
            string desiredMonth = DateTime.Now.ToString("MMMM");
            int selectedDay = 0;

            //Puts the departing and returning tabs in to a list so i can then switch between the active and inactive tabs (or displayed and not displayed)
            IList<IWebElement> drawerTab = Act.browserInstance.FindElements(By.ClassName("drawer-tab-content"));

            //forloop to ensure i am on the active/displayed tab before executing any actions
            foreach (var itemTabs in drawerTab)
            {
                if (itemTabs.Displayed == true)
                {

                    //list all the months on the active/displayed tab
                    ICollection<IWebElement> listMonths = itemTabs.FindElements(By.ClassName("month"));

                    //forloop to ensure i am on the next month before executing any further actions
                    //risk with staying on current month is there is only 1 day left, then its more complex to choose a returning day for the following month
                    foreach (var itemMonth in listMonths)
                    {
                        if (itemMonth.Text.Contains(desiredMonth)){
                            //loop though to next month
                        }else{

                            //lists of all selectable dates for that month
                            ICollection<IWebElement> listSelectableDays = itemMonth.FindElements(By.ClassName("selectable"));

                            //selects the the departing and returning days
                            foreach (var itemDay in listSelectableDays)
                            {

                                //this code will run if the returning tab is active/displayed
                                if (drawerTab[1].Displayed == true){
                                    if (Convert.ToInt32(itemDay.Text).Equals(selectedDay + 7).Equals(true)){
                                        itemDay.Click();
                                        break;
                                    }
                                }
                                //this code will run if the departing tab is active/displayed
                                else
                                {
                                    selectedDay = Convert.ToInt32(itemDay.Text);
                                    itemDay.Click();
                                    Act.browserInstance.FindElement(By.Id("close-drawer-link")).Click();
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public static void Adults(string NumberOfAdults)
        {
            //Defaults to 1
        }

        public static void Children(string NumberOfChildren)
        {
            //Defaults to 0
        }

        public static void Infants(string NumberOfInfants)
        {
            //Defaults to 0
        }

        public static void ShowFlights()
        {
            SpoHomePage.ShowFlights.Click();
        }

        public static void HappyPath(string FlightFrom, string FlightTo)
        {
            Flights_From(FlightFrom);
            Flights_To(FlightTo);
            Date_RetrunFlight();
            ShowFlights();
        }
    }
}
