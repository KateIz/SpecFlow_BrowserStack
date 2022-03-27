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

        [When(@"Accept coockies")]
        public void AcceptCoockies()
        {
            Assert.IsTrue(home_page.ClickAcceptCookies());
        }

        [Then(@"I should see BBC portal")]
        public void ThenIShouldSeeBBCPortal()
        {
            Assert.IsTrue(home_page.VerifyUrl());
        }

        [When(@"I click Sign In")]
        public void WhenIClickSignIn()
        {
          Assert.IsTrue(home_page.ClickSignIn());
        }

        [When(@"I click Register Now")]
        public void WhenIClickRegisterNow()
        {
            home_page.ClickRegisterNow();
        }
    }
}
