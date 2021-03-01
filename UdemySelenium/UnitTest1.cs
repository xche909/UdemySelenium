using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UdemySelenium.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace UdemySelenium
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//*[@id=\"maincont\"]/div[1]/div[4]/div[2]/div[2]/div/ul/li[1]/label/div[1]")).Click();

            string combocControlName = "ContentPlaceHolder1_AllMealsCombo";
            //CustomControl.ComboBox(combocControlName, "Almond");


            Assert.Pass();
        }

        //[Test]
        //public void LoginTest()
        //{
        //    Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        //    HomePage homePage = new HomePage();
        //    LoginPage loginPage = new LoginPage();

        //    homePage.ClickLogin();

        //    loginPage.EnterUserNameAndPassword("admin","password");
        //    loginPage.ClickLogin();

        //    Assert.That(homePage.logOffExists, Is.True, "Log off button not displayed");
        //}

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }
        
    }
}