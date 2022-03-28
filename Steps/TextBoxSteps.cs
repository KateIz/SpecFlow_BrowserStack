using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using Pages;
using SpecFlowNewProject.Hooks;

namespace Steps
{
    [Binding]
    public sealed class TextBoxSteps : BaseSteps
    {
        TextBoxPage textBoxPage;

        //private IWebDriver driver;
        //private IWebDriver _driver;
        public TextBoxSteps(IWebDriver driver):base(driver)
        {
            textBoxPage = new TextBoxPage(_driver);
            _driver = driver;
            
        }
        //TextBoxPage textboxpage = new TextBoxPage();


        [Given(@"Go to page")]
        public void GivenGoToPage()
        {
            //_driver.Navigate().GoToUrl("www.demoqa.com");
            Assert.IsTrue(textBoxPage.OpenTextBoxPage());
        }

       
        [Then(@"I should see DemoQA page")]
        public void ThenIShouldSeeDemoQAPage()
        {
            Assert.IsTrue(textBoxPage.VerifyUrl());
        }

        [When(@"I click Text box section")]
        public void WhenIClickTextBoxSection()
        {
            textBoxPage.ClickTextBox();
        }

        [When(@"I fill in the form")]
        public void WhenIFillInTheForm()
        {
            textBoxPage.FillTheForm();
        }

        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            textBoxPage.ClickSubmit();
        }

        [Then(@"I should see the Name in the form Name")]
        public void ThenIShouldSeeTheNameInTheFormName()
        {
            Assert.IsTrue(textBoxPage.VerifyTheFormName());
        }

        [Then(@"I should see the Email in the form Email")]
        public void ThenIShouldSeeTheEmailInTheFormEmail()
        {
            Assert.IsTrue(textBoxPage.VerifyTheFormEmail());
        }

        [Then(@"I should see the Adress in the form Adress")]
        public void ThenIShouldSeeTheAdressInTheFormAdress()
        {
            Assert.IsTrue(textBoxPage.VerifyTheFormAdress());
            
        }
    }

}

      