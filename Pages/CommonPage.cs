using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace Pages
{
    class CommonPage
    {
        public IWebDriver _driver;
        
        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool OpenTextBoxPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return true;
        }

        public bool VerifyUrl(String url1)
        {
            String page_url = _driver.Url;

            bool isValid;
            if (page_url.Contains(url1))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        public void AcceptCookies()
        {
            Thread.Sleep(3000);
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='onetrust-accept-btn-handler']"))).Click();
        }
    }
}
