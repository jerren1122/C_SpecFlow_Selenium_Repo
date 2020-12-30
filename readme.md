This Repository Serves the Purpose of being living documentation as to how a SpecFlow Selenium Web Automation Repo functions. The following functionality is utilized in this framework: 

-SpecFlow-
--Use cases for hooks and step definitions are included. 
--Good Overview on Implementing SpecFlow: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted
--the scenario_context objects for step definitions and hooks is the bridge to be able to pass the driver from the hooks class to the step definitions class. This is set in the hooks and referenced in the step definitions. 
  --Scenario Context Documentation: https://docs.specflow.org/projects/specflow/en/latest/Bindings/ScenarioContext.html

-Selenium and Chrome-
--Selenium and Chrome can be installed as extensions
--How to Implement Selenium and Chrome: https://www.c-sharpcorner.com/article/selenium-automation-test-cases-for-the-net-web-application/

-PageObject and PageFactory-
--DotNetSeleniumExtras.PageObjects.Core and DotNetSeleniumExtras.PageObjects can be installed as nuget packages. 
--How to implement PageObject: https://www.swtestacademy.com/page-object-model-c/3

-NUnit-
--This is how we surface assertions into the step definition layer
-- Need to also install NUnit as a nuget package for the solution: Install-Package Specflow.NUnit and then include it 

-Command Line Execution-
--running the command "dotnet test" will run all tests in the SpecFlow suite. 
--running the command "dotnet test --filter TestCategory=shoes" will only run the tests tagged with "@shoes"
--This thread if you search for "dotnet" has a concise explanatation of how utilizing tagging functions. https://stackoverflow.com/questions/20613221/how-do-you-run-specflow-scenarios-from-the-command-line-using-mstest
