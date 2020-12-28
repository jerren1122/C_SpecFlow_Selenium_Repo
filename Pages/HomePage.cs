using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CSpecFlowSelenium.Hooks;

namespace CSpecFlowSelenium.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "search_query_top")]
        protected IWebElement UsernameTxtBox { get; set; }

        [FindsBy(How = How.Name, Using = "submit_search")]
        protected IWebElement SubmitSearch { get; set; }

        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
    
        }

    }
}
