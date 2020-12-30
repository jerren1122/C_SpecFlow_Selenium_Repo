using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace CSpecFlowSelenium.Pages
{
    class SearchResultsPage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "product-container")]
        protected IWebElement FirstResult { get; set; }

        private readonly IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SelectFirstResult()
        {
            FirstResult.Click();
        }

    }
}

