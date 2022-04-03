using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pages
{
    public class BookStorePage
    {
        protected WebDriverWait wait;
        private IWebDriver _driver;

        public BookStorePage(IWebDriver driver)
        {
            _driver = driver;
    }

        private IWebElement BtnBookStoreApp => _driver.FindElement(By.XPath("//*[text()='Book Store Application']"));
        private IWebElement HrefWebSite => _driver.FindElement(By.XPath("//*[@id='website-wrapper']/div[2]"));
        private IWebElement BtnSearch => _driver.FindElement(By.XPath("//*[@id='js-searchButton']"));
        private IWebElement TxtSearch => _driver.FindElement(By.XPath("//*[@id='search']"));
        private IWebElement BookDescription => _driver.FindElement(By.XPath("//*[@class='orm-Truncate-root orm-Truncate-lineClamp02 orm-Truncate-hyphens']"));
        private IWebElement BtnBooksName => _driver.FindElement(By.XPath("//h4[@class='Title--WmlEB']"));
        private IWebElement BtnBuyAmazon => _driver.FindElement(By.XPath("//*[@class='buy-button-group']/*[@class='button-primary']"));
        




        public void ClickButton()
        {
            BtnBookStoreApp.Click();
        }
        public void ClickGitPocketGide()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='see-book-Git Pocket Guide']"))).Click();
            
        }
        public void ClickHref()
        {
            HrefWebSite.Click();
        }
        
        public void ClickSearch()
        {
            BtnSearch.Click();
        }
        public void AddText(string text)
        {
            TxtSearch.SendKeys(text);
            TxtSearch.SendKeys(Keys.Enter);
            
        }
        public bool VerifyText(string text)
        {
            Thread.Sleep(3000);
            _driver.SwitchTo().DefaultContent();

            string description = BookDescription.Text;

            bool isValid;
            if (description.Contains(text))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        public void ClickBooksName()
        {
            BtnBooksName.Click();
        }

        public void ClickBtnBuyAmazon()
        {
            Thread.Sleep(1000);
            BtnBuyAmazon.Click();
        }
        
    }
}
