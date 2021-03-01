using System;
using OpenQA.Selenium;

namespace UdemySelenium.Pages
{
    public class HomePage : DriverHelper
    {
        public HomePage()
        {
        }

        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement LnkLogOff => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool logOffExists => LnkLogOff.Displayed;
    }
}
