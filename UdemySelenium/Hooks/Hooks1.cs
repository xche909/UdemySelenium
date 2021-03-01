using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace UdemySelenium.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        private DriverHelper _driverHelper;

        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;
        

        [BeforeStep]
        public void BeforeStep()
        {
            // TODO: implement logic that has to run before each scenario step
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // For storing and retrieving feature-specific data, the 
            //     FeatureContext.Current
            // collection can be used.
            // Use the attribute overload to specify tags. If tags are specified, the event 
            // handler will be executed only if any of the tags are specified for the 
            // feature or the scenario.
            //     [BeforeStep("mytag")]
        }

        [AfterStep]
        public void AfterStep()
        {
            // TODO: implement logic that has to run after each scenario step
        }

        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            // TODO: implement logic that has to run before each scenario block (given-when-then)
            
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            // TODO: implement logic that has to run after each scenario block (given-when-then)
            
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // TODO: implement logic that has to run before executing each scenario
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            _driverHelper.Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // TODO: implement logic that has to run after executing each scenario
            _driverHelper.Driver.Quit();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            // TODO: implement logic that has to run before executing each feature
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            // TODO: implement logic that has to run after executing each feature
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // TODO: implement logic that has to run before the entire test run
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // TODO: implement logic that has to run after the entire test run
        }
    }
}
