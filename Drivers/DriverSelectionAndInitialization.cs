using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowNewProject.Drivers
{
    public class DriverSelectionAndInitialization
    {

        public static IWebDriver _driver;

        public static IWebDriver ChromeDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            return _driver;
        }

        public static IWebDriver BSDriver()

        {
            ChromeOptions capabilities = new ChromeOptions();
            capabilities.BrowserVersion = "latest";
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            browserstackOptions.Add("buildName", "Build 1");
            browserstackOptions.Add("sessionName", "Test DemoQA");
            browserstackOptions.Add("os", "Windows");
            browserstackOptions.Add("osVersion", "10");
            browserstackOptions.Add("projectName", "TrainingProject");
            browserstackOptions.Add("local", "false");
            browserstackOptions.Add("seleniumVersion", "4.0.0");
            browserstackOptions.Add("userName", "katerynaizviekov_TORzX2");
            browserstackOptions.Add("accessKey", "bgVtEU3TcPUe5khziVkT");
            capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
            _driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capabilities);
            return _driver;
        }


    }
}
