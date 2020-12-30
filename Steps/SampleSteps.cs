using TechTalk.SpecFlow;
using CSpecFlowSelenium.Pages;
using OpenQA.Selenium;
using System;
using System.Reflection;
using NUnit.Framework;

namespace CSpecFlowSelenium.Steps


{
    [Binding]
    public sealed class SampleSteps
    {
        private readonly IWebDriver _driver;
        public BasePage page;
        public Type t; 


        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SampleSteps(ScenarioContext scenarioContext)
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given("the user validates the page url displays '(.*)'")]
        public void TheUserValidatesThePageDisplays(string text)
        {
            Assert.IsTrue(_driver.Url.ToLower().Contains(text));
        }


        [Given("the user fills in (.*)")]
        public void GivenTheUserFillsIn(string text)
        {
            page.Fill(text);
        }


        [Given("the user clicks (.*)")]
        public void GivenTheUserClicks(string element)
        {
            Type thisType = page.GetType();
            MethodInfo theMethod = thisType.GetMethod(element);
            theMethod.Invoke(page, null);
        }

        [Given("the application navigates to the (.*)")]
        public void GivenTheApplicationNavigatesToThe(string pageText)
        {
            Type t = Type.GetType("CSpecFlowSelenium.Pages." + pageText);
            page = (BasePage)Activator.CreateInstance(t, _driver);
        }
    }
}
