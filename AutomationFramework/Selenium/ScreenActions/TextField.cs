using ejHome.AutomationFramework.Selenium.BaseElements;
using OpenQA.Selenium;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.AutomationFramework.Selenium.ScreenActions
{
    public class TextField : BaseElement
    {
        private By selector { get; set; }

        public string value
        {
            get
            {
                return CurrentValue();
            }
            set
            {
                this.EnterValue(value);
            }
        }

        public TextField(SelectBy selectBy, string SelectorElement)
        {
            selector = BySelector(selectBy, SelectorElement);
        }

        private string CurrentValue()
        {
            return Element(selector).GetAttribute("value");
        }

        private void EnterValue(string value)
        {
            Element(selector).Clear();
            Element(selector).SendKeys(value);
        }

        public void Click()
        {
            Element(selector).Click();
        }
    }
}
