using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNewProject.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowNewProject.Hooks
{
    [Binding]
    public class MyHooks
    {
        private ScenarioContext _scenarioContext;
        public static IWebDriver _driver;

        public MyHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        private static IWebDriver InitializeChromeWebDriver()
        {
            //WebDriver driver = new ChromeDriver();
            _driver = DriverSelectionAndInitialization.WebDriver();
            return _driver;
        }
    }
}


