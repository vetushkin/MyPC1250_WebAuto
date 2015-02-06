using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPC1250_WebAuto.PageObjects.MyPC
{
    public class MyPCLoginPage : BasePageObject
    {
        public static Element LoginTextField = new Element("LoginTextField", By.XPath(".//*[@id='ctl00_PageContent_txtUserName']"));
        public static Element PasswordTextField = new Element("PasswordTextField", By.XPath(".//*[@id='ctl00_PageContent_txtPassword']"));
        public static Element AuthenticateButton = new Element("AuthenticateButton", By.XPath(".//*[@id='ctl00_PageContent_btnAuthenticate']"));
        public static Element DomainList = new Element("DomainList", By.XPath(".//*[@id='ctl00_PageContent_ddlDomains_Input']"));
        public static Element ProjectList = new Element("ProjectList", By.XPath(".//*[@id='ctl00_PageContent_ddlProjects_Input']"));
        public static Element LoginButton = new Element("LoginButton", By.XPath(".//*[@id='ctl00_PageContent_btnLogin']"));

        public override void WaitForElements()
        {
            LoginTextField.Verify().Present();
            PasswordTextField.Verify().Present();
            AuthenticateButton.Verify().Present();
            //DomainList.Verify().Present();
            //ProjectList.Verify().Present();
            //LoginButton.Verify().Present();
        }
    }
}
