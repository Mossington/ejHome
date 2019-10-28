using ejHome.SpecFlow.Support.Helpers;
using TechTalk.SpecFlow;

namespace ejHome.SpecFlow.StepDefinition
{
    [Binding]
    public sealed class UserCreation
    {
        [Given(@"I have reached the booking confimraiton page of the DA Funnel")]
        public void GivenIHaveReachedTheBookingConfimraitonPageOfTheDAFunnel()
        {
            //Search Pod Form
            HomePage_FlightsSearchPod.HappyPath("Bristol", "Amsterdam");

            //HomePage_FlightsSearchPod.HappyPath();




            //PickFlights.HappyPath();

            //Pick flights
            //Helping Hand Continue
            //Hold Luggage & Sports Equipment
            //Helping Hand Continue
            //Car Hire
            //Helping Hand Continue
            //Bistro Vouchers
            //Helping Hand Continue
            //Travel Insurance
            //Helping Hand Continue
        }

        [When(@"i have completed the new user creation form")]
        public void WhenIHaveCompletedTheNewUserCreationForm()
        {
            //Bookers contact details
        }

        [Then(@"i am shown as being logged on to the EasyJet website")]
        public void ThenIAmShownAsBeingLoggedOnToTheEasyJetWebsite()
        {
            //Checkout
            //Checkout Terms and Conditions
            //Payments
        }
    }
}
