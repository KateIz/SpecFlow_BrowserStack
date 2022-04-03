using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
   public class BookStoreSteps : BaseSteps
    {
        BookStorePage bookStorePage;
        CommonPage commonPage;

        public BookStoreSteps(IWebDriver driver) : base(driver)
        {
            bookStorePage = new BookStorePage(_driver);
            commonPage = new CommonPage(_driver);
        }
              

            [When(@"I click on Book Store Application section")]
            public void WhenIClickOnBookStoreApplicationSection()
            {
            bookStorePage.ClickButton();
            }

            [When(@"I click on Git Pocket Guide")]
            public void WhenIClickOnGitPocketGuide()
            {
            
            bookStorePage.ClickGitPocketGide();
            }

            [When(@"I click Website link")]
            public void WhenIClickWebsiteLink()
            {
            bookStorePage.ClickHref();
        }

            [When(@"I click Search")]
            public void WhenIClickSearch()
            {
            bookStorePage.ClickSearch();
            }

            [When(@"Add '(.*)' to field")]
            public void WhenAddToField(string text)
            {
            bookStorePage.AddText(text);
            }

            [When(@"I click on book's name")]
            public void WhenIClickOnBooksName()
            {
            bookStorePage.ClickBooksName();
            }

            [When(@"I close Preview Content Library")]
            public void WhenIClosePreviewContentLibrary()
            {
               
            }

            [When(@"I click button Buy on Amazon")]
            public void WhenIClickButtonBuyOnAmazon()
            {
            bookStorePage.ClickBtnBuyAmazon();
            }

            [When(@"I click Add to Cart button")]
            public void WhenIClickAddToCartButton()
            {
               
            }

            [When(@"I go to Cart")]
            public void WhenIGoToCart()
            {
                
            }

            [When(@"I click Proceed to Checkout")]
            public void WhenIClickProceedToCheckout()
            {
                
            }

            [Then(@"I should see the book with '(.*)'")]
            public void ThenIShouldSeeTheBookWith(string text)
            {
            Assert.IsTrue(bookStorePage.VerifyText(text));
            }
            
            [Then(@"I verify url contains '(.*)'")]
            public void ThenIVerifyUrlContains(string url1)
            {
                Assert.IsTrue(commonPage.VerifyUrl(url1));
            }

            [Then(@"I verify qty in order")]
            public void ThenIVerifyQtyInOrder()
            {
                
            }

            [Then(@"I see Amazon Sign-In page")]
            public void ThenISeeAmazonSign_InPage()
            {
                
            }
        public class StepDefinitions
        {
            private readonly ScenarioContext _scenarioContext;

            public StepDefinitions(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
        }
    }
}

