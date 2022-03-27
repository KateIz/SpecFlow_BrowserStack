using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using Pages;

namespace Steps
{
    [Binding]
    public sealed class HomePageSteps
    {

        HomePage home_page = new HomePage();
        [Given(@"Go to page")]
        public void GivenGoToPage()
        {
            Assert.IsTrue(home_page.OpenHomePage());
        }

       
        [Then(@"I should see DemoQA page")]
        public void ThenIShouldSeeDemoQAPage()
        {
            Assert.IsTrue(home_page.VerifyUrl());
        }

        [When(@"I click Text box section")]
        public void WhenIClickTextBoxSection()
        {
            home_page.ClickTextBox();
        }

        [When(@"I fill in the form")]
        public void WhenIFillInTheForm()
        {
            home_page.FillTheForm();
        }

        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            home_page.ClickSubmit();
        }

        [Then(@"I should see the Name in the form Name")]
        public void ThenIShouldSeeTheNameInTheFormName()
        {
            Assert.IsTrue(home_page.VerifyTheFormName());
        }

        [Then(@"I should see the Email in the form Email")]
        public void ThenIShouldSeeTheEmailInTheFormEmail()
        {
            Assert.IsTrue(home_page.VerifyTheFormEmail());
        }

        [Then(@"I should see the Adress in the form Adress")]
        public void ThenIShouldSeeTheAdressInTheFormAdress()
        {
            Assert.IsTrue(home_page.VerifyTheFormAdress());
        }
    }

}

      