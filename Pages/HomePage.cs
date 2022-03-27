using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace Pages
{
   [Binding]
    public class HomePage
    {
        IWebDriver driver = new ChromeDriver();

        public bool OpenHomePage()
            {
                string url = "https://demoqa.com/";
                driver.Navigate().GoToUrl(url);
                return true;
            }


            public bool VerifyUrl()
            {
                String page_url = driver.Url;
                string url = "https://demoqa.com/";

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
    }
}
