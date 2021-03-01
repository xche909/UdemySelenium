using System;
using OpenQA.Selenium;

namespace UdemySelenium.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement lnkLogin => _driver.FindElement(By.LinkText("Login"));

        IWebElement LnkLogOff => _driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool logOffExists => LnkLogOff.Displayed;
    }
}
