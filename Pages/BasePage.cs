using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        //protected ScenarioContext _scenarioContext;
        protected WebDriverWait _wait;
        protected int _timeout = 20;
        //protected readonly ISpecFlowOutputHelper _specflowOutputHelper;

        protected BasePage(IWebDriver driver) //, ScenarioContext scenarioContext, ISpecFlowOutputHelper specflowOutputHelper
        {
            _driver = driver;
           //_scenarioContext = scenarioContext;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_timeout));
            //_specflowOutputHelper = specflowOutputHelper;
        }
    }
}
