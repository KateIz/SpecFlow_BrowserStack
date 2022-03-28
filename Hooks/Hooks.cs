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
       // private ScenarioContext _scenarioContext;
        public static IWebDriver _driver;
        private readonly IObjectContainer objectContainer;

        public MyHooks(IObjectContainer objectContainer)
        {
            //_scenarioContext = scenarioContext;
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        private void InitializeChromeWebDriver()
        {
            //string testcaseName = _scenarioContext.ScenarioInfo.Title;
            _driver = DriverSelectionAndInitialization.WebDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            //return _driver;
        }
    }
}


