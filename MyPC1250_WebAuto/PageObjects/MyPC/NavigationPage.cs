using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPC1250_WebAuto.PageObjects.MyPC
{


    public class NavigationPage:BasePageObject
    {
        public override void WaitForElements()
        {
        }
    }

    public class Navigation : NavigationPage
    {
        public static void OpenStartPage()
        {
            NavigationPage navigation = new NavigationPage();
            int before = navigation.driver.WindowHandles.ToList().Count;
            
            do
            {
                IList<string> afterPopup = navigation.driver.WindowHandles.ToList();
            } while (navigation.driver.WindowHandles.ToList().Count ==before);

            navigation.driver.SwitchTo().Window(navigation.driver.WindowHandles.Last());
        }
    }
}
