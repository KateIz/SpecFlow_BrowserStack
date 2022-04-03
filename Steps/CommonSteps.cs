using NUnit.Framework;
using OpenQA.Selenium;
using Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Steps
{
    class CommonSteps : BaseSteps
    {

        CommonPage commonPage;
        public CommonSteps(IWebDriver driver) : base (driver)
        {
            commonPage = new CommonPage(_driver);
        }

        [Given(@"Go to page '(.*)'")]
        public void GivenGoToPage(String url)
        {
            Assert.IsTrue(commonPage.OpenTextBoxPage(url));
        }

        [Then(@"I should see '(.*)'")]
        public void ThenIShouldSee(string url)
 
        {
            Assert.IsTrue(commonPage.VerifyUrl(url));
        }

    }
}
