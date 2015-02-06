using MbUnit.Framework;
using MyPC1250_WebAuto.PageObjects.MyPC;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;

namespace MyPC_1250_UI_Automation.Tests
{
    class LoginInMyPC : WebDriverTestBase
    {
        

        [Test]
        public void LoginInPC()
        {
            OpenPage<MyPCLoginPage>("http://myd-vm03805:8080/qcbin/loadtest/");
            MyPCLoginPage.LoginTextField.Clear();
            MyPCLoginPage.LoginTextField.SendKeys("sa");
            MyPCLoginPage.PasswordTextField.Clear();
            MyPCLoginPage.AuthenticateButton.Click();
            //MyPCLoginPage.DomainList.Click();
            //MyPCLoginPage.ProjectList.Click();
            MyPCLoginPage.LoginButton.WaitUntil().Present().Click();

            //Need to find a better solution!
            NavigationPage navigation = new NavigationPage();
            navigation.OpenStartPage();

            StartPage.LogOutButton.Click();
        }
    }
}
