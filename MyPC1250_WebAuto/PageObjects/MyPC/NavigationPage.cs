using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPC1250_WebAuto.PageObjects.MyPC
{
    public class NavigationPage : BasePageObject
    {
        public void OpenStartPage()
        {
            do
            {
                IList<string> afterPopup = driver.WindowHandles.ToList();
            } while (driver.WindowHandles.ToList().Count <= 1);

            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public override void WaitForElements()
        {
        }
    }
}
