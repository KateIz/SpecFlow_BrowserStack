using BoDi;
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
    public sealed class MyHooks
    {
        //private ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private readonly IObjectContainer objectContainer;

        public MyHooks(IObjectContainer objectContainer)
        {
            //_scenarioContext = scenarioContext;
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        private void InitializeChromeWebDriver()
        {

            switch ("local")
            {
                case "local":
                    _driver = DriverSelectionAndInitialization.ChromeDriver();
                    objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
                case "BrowserStack":
                    _driver = DriverSelectionAndInitialization.BSDriver();
                    objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
            }
        }

        [AfterScenario]
        private void CloseWebDriver()
        {
            _driver.Quit();
        }
    }
}


