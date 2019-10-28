using ejHome.SpecFlow.Support.BaseStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejHome.AutomationFramework.DriverClass
{
    public class Browser
    {
        public static void SwtichToTab(int tab)
        {
            List<string> tabs = new List<string>(Act.browserInstance.WindowHandles);
            Act.browserInstance.SwitchTo().Window(tabs[tab]);
        }

        public static void CloseTab(int tab)
        {
            List<string> tabs = new List<string>(Act.browserInstance.WindowHandles);
            Act.browserInstance.SwitchTo().Window(tabs[tab]);
            Act.browserInstance.Close();
        }
    }
}
