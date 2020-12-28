using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace CSpecFlowSelenium.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        ChromeDriver driver;

         [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver("C:/Users/Jerren/source/repos/CSpecFlowSelenium/Drivers");
            driver.Navigate().GoToUrl(@"http://w3schools.com");
        }

        [AfterScenario]
        public void AfterScenario()
        {
        //do studff
        }
    }
}
