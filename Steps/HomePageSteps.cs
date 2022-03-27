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

        
    }
}
