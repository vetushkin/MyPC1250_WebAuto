using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPC1250_WebAuto.PageObjects.MyPC
{
    public class StartPage : BasePageObject
    {
        public static Element LogOutButton = new Element("LogOutButton", By.XPath(".//*[@id='MastheadDiv']//*[@local-string='ogout']"));
        


        public override void WaitForElements()
        {
            LogOutButton.Verify().Present();
        }
    }
}
