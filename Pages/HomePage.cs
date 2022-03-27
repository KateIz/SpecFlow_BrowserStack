using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;


namespace Pages
{
   [Binding]
    public class HomePage
    {
        IWebDriver driver;


        public bool OpenHomePage()
            {
                driver = new ChromeDriver();
                string url = "https://www.bbc.com/";
                driver.Navigate().GoToUrl(url);
                return true;
            }

            public bool ClickAcceptCookies()
            {
                IWebElement button = driver.FindElement(By.XPath("//p[contains(text(),'Consent')]"));
                if (button.Displayed)
                {
                    button.Click();
                    Console.WriteLine("Udalo sie!!! xD");
                    return true;
                }
                else
                {
                    Console.WriteLine("nie udalo sie!!! xD");
                    return false;
                }
            }

            public bool VerifyUrl()
            {
                String page_url = driver.Url;
                string url = "www.bbc.com";

                bool isValid;
                if (page_url.Contains(url))
                {
                    isValid = true;
                    Console.WriteLine("Udało się:");
                }
                else
                {
                    isValid = false;
                    Console.WriteLine("Nie udało się:");
                }
                return isValid;
            }
            public bool ClickSignIn()
            {
              IWebElement button = driver.FindElement(By.Id("idcta-link"));
                if (button.Displayed)
                {
                    button.Click();
                    Console.WriteLine("Udalo sie!!! xD");
                    return true;
                }
                else
                {
                    Console.WriteLine("nie udalo sie!!! xD");
                    return false;
                }
                
                return true;

            }
        
            public void ClickRegisterNow()
        {                                                             
            IWebElement BtnRegisterNow = driver.FindElement(By.XPath("//a[contains(@class,'link--primary')]"));    
            BtnRegisterNow.Click();
        }
    }
}
