using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace Pages
{
   [Binding]
    public class TextBox
    {
        IWebDriver driver = new ChromeDriver();
        private IWebElement BtnElements => driver.FindElement(By.XPath("//*[text()='Elements']"));
        private IWebElement BtnTextBox => driver.FindElement(By.XPath("//*[text()='Text Box']"));
        private IWebElement InputBoxFullName => driver.FindElement(By.XPath("//*[@id='userName']"));
        private IWebElement InputBoxEmail => driver.FindElement(By.XPath("//*[@id='userEmail']"));
        private IWebElement InputBoxCurrentAdress => driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement BtnSubmit => driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement NameSummary => driver.FindElement(By.XPath("//*[@id='name']"));
        private IWebElement EmailSummary => driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement AdressSummary => driver.FindElement(By.XPath("//p[@id='currentAddress']"));



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
                }
                else
                {
                    isValid = false;
                }
            
            return isValid;  
            
            }
        public void ClickTextBox()
        {
            BtnElements.Click();
            BtnTextBox.Click();
        }

        public void FillTheForm ()
        {
            InputBoxFullName.SendKeys("Kateryna Izviekova");
            InputBoxEmail.SendKeys("katizvekova@gmail.com");
            InputBoxCurrentAdress.SendKeys("Wrocław, Kamienna");
        }
        public void ClickSubmit()
        {
            BtnSubmit.Click();
        }

        public bool VerifyTheFormName()
        {
            String Name = NameSummary.Text;
            String imie = "Kateryna Izviekova";

            bool isValid;
            if (Name.Contains(imie))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
        return isValid;

        }

        public bool VerifyTheFormEmail()
        {
            String Email = EmailSummary.Text;
            String mail = "@";

            bool isValid;
            if (Email.Contains(mail))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;

        }

        public bool VerifyTheFormAdress()
        {
            String Adress = AdressSummary.Text;
            String adr = "Wrocław";

            bool isValid;
            if (Adress.Contains(adr))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            driver.Quit(); 
            return isValid;

        }
    }
}
