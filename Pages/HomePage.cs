using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using CSpecFlowSelenium.Hooks;
using System.Reflection;

namespace CSpecFlowSelenium.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "search_query_top")]
        protected IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "submit_search")]
        protected IWebElement SubmitSearch { get; set; }

        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public override void Fill(String text)
        {
            SearchBox.SendKeys(text);
        }

        public void Search()
        {
            SubmitSearch.Click();
        }

    }
}
