using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class TextBoxPage
    {
        private IWebDriver _driver;

        public TextBoxPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement BtnElements => _driver.FindElement(By.XPath("//*[text()='Elements']"));
        private IWebElement BtnTextBox => _driver.FindElement(By.XPath("//*[text()='Text Box']"));
        private IWebElement InputBoxFullName => _driver.FindElement(By.XPath("//*[@id='userName']"));
        private IWebElement InputBoxEmail => _driver.FindElement(By.XPath("//*[@id='userEmail']"));
        private IWebElement InputBoxCurrentAdress => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement BtnSubmit => _driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement NameSummary => _driver.FindElement(By.XPath("//*[@id='name']"));
        private IWebElement EmailSummary => _driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement AdressSummary => _driver.FindElement(By.XPath("//p[@id='currentAddress']"));

        public void ClickTextBox()
        {
            BtnElements.Click();
            BtnTextBox.Click();
        }

        public void FillTheForm()
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
            return isValid;
        }
    }
}
