using OpenQA.Selenium;

namespace ejHome.AutomationFramework.Selenium.BaseElements
{
    public class BaseBySelector
    {
        private static By selector;

        /// <summary>
        /// enum values = 0=Name, 1=Id, 2=Class, 3=CssSelector 
        /// </summary>
        public enum SelectBy
        {
            Name,
            Id,
            Class,
            CssSelector,
        }

        public static By BySelector(SelectBy selectBy, string Selector)
        {
            switch (selectBy)
            {
                case SelectBy.Name:
                    selector = By.Name(Selector);
                    break;
                case SelectBy.Id:
                    selector = By.Id(Selector);
                    break;
                case SelectBy.Class:
                    selector = By.ClassName(Selector);
                    break;
                case SelectBy.CssSelector:
                    selector = By.CssSelector(Selector);
                    break;
            }
            return selector;
        }
    }
}
