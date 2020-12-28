using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using CSpecFlowSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CSpecFlowSelenium.Steps


{
    [Binding]
    public sealed class SampleSteps {
        private readonly IWebDriver _driver;


        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SampleSteps(ScenarioContext scenarioContext)
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given("the user clicks (.*)")]
        public void GivenTheUserSelects(string element)
        {
        
            
        }

        [Given("the application navigates to the (.*)")]
        public void GivenTheApplicationNavigatesToThe(string pageText)
        {
            pageText.Split();
        }
    }
}
