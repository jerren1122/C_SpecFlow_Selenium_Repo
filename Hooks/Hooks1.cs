using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using CSpecFlowSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CSpecFlowSelenium.Hooks
{
    [Binding]
    public class Hooks1
    {
        public ChromeDriver driver;
        


        [BeforeScenario]
        public

           void BeforeScenario()
        {
            driver = new ChromeDriver("C:/Users/Jerren/source/repos/CSpecFlowSelenium/Drivers");
            driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
            ScenarioContext.Current["driver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //do studff
        }
    }
}
