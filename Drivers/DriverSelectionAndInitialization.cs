using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowNewProject.Drivers
{
    public class DriverSelectionAndInitialization
    {

        public static IWebDriver _driver;

        public static IWebDriver WebDriver()
        {
            _driver = new ChromeDriver();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            return _driver;
        }
    }
}
