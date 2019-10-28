using ejHome.SpecFlow.Support.BaseStep;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;

namespace ejHome.AutomationFramework.Selenium.BaseElements
{
    public class BaseElement
    {
        protected IWebElement Element(By by)
        {
            WebDriverWait wait = new WebDriverWait(Act.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

            return Act.browserInstance.FindElement(by);
        }

        protected ICollection Elements(By by)
        {
            WebDriverWait wait = new WebDriverWait(Act.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

            return Act.browserInstance.FindElements(by);
        }
    }
}
