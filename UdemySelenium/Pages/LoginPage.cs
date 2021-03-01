using System;
using OpenQA.Selenium;

namespace UdemySelenium.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement txtUserName => _driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => _driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));

        public void ClickLogin() => btnLogin.Click();

        public void EnterUserNameAndPassword(string userName, string password){

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


    }
}
