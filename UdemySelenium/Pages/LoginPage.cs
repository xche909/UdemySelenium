using System;
using OpenQA.Selenium;

namespace UdemySelenium.Pages
{
    public class LoginPage : DriverHelper
    {
        public LoginPage()
        {
        }

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));

        public void ClickLogin() => btnLogin.Click();

        public void EnterUserNameAndPassword(string userName, string password){

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


    }
}
