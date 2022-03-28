using OpenQA.Selenium;
using Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Steps
{
    [Binding]
    public abstract class BaseSteps
    {
        //protected ScenarioContext _scenarioContext;
        protected IWebDriver _driver;

        public BaseSteps(IWebDriver driver)
        {
            _driver = driver;
            //_scenarioContext = scenarioContext;
        }
    }
}
