using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages
{
    class CommonPage
    {
        private IWebDriver _driver;
        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool OpenTextBoxPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return true;
        }

        public bool VerifyUrl(String url)
        {
            String page_url = _driver.Url;

            bool isValid;
            if (page_url.Contains(url))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
