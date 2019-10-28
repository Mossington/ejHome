using ejHome.AutomationFramework.Selenium.BaseElements;
using OpenQA.Selenium;
using static ejHome.AutomationFramework.Selenium.BaseElements.BaseBySelector;

namespace ejHome.AutomationFramework.Selenium.ScreenActions
{
    public class StaticContent : BaseElement
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
                //
            }
        }

        public StaticContent(SelectBy selectBy, string SelectorElement)
        {
            selector = BySelector(selectBy, SelectorElement);
        }

        private string CurrentValue()
        {
            return Element(selector).Text;
        }
    }
}
