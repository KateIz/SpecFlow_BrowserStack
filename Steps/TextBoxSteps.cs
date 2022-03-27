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
    public sealed class TextBoxSteps
    {

        TextBox textbox_page = new TextBox();
        [Given(@"Go to page")]
        public void GivenGoToPage()
        {
            Assert.IsTrue(textbox_page.OpenHomePage());
        }

       
        [Then(@"I should see DemoQA page")]
        public void ThenIShouldSeeDemoQAPage()
        {
            Assert.IsTrue(textbox_page.VerifyUrl());
        }

        [When(@"I click Text box section")]
        public void WhenIClickTextBoxSection()
        {
            textbox_page.ClickTextBox();
        }

        [When(@"I fill in the form")]
        public void WhenIFillInTheForm()
        {
            textbox_page.FillTheForm();
        }

        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            textbox_page.ClickSubmit();
        }

        [Then(@"I should see the Name in the form Name")]
        public void ThenIShouldSeeTheNameInTheFormName()
        {
            Assert.IsTrue(textbox_page.VerifyTheFormName());
        }

        [Then(@"I should see the Email in the form Email")]
        public void ThenIShouldSeeTheEmailInTheFormEmail()
        {
            Assert.IsTrue(textbox_page.VerifyTheFormEmail());
        }

        [Then(@"I should see the Adress in the form Adress")]
        public void ThenIShouldSeeTheAdressInTheFormAdress()
        {
            Assert.IsTrue(textbox_page.VerifyTheFormAdress());
            
        }
    }

}

      