Good Overview on Implementing SpecFlow: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted
How to Implement Selenium and Chrome: https://www.c-sharpcorner.com/article/selenium-automation-test-cases-for-the-net-web-application/
How to implement PageObject: https://www.swtestacademy.com/page-object-model-c/3
Need to also implement PageFactory as a nuget package for the solution: DotNetSeleniumExtras.PageObjects.Core and then include
Need to also install NUnit as a nuget package for the solutio: Install-Package Specflow.NUnit and then include it 
Scenario Context Documentation: https://docs.specflow.org/projects/specflow/en/latest/Bindings/ScenarioContext.html

Check the scope of variables in classes; 

We need to utilize Hooks
-Need to know how to utilize conditional hooks as well

We need to run from the command line and create a batch file that captures those steps 

We need to know how tagging works. 
-Be able to exclude and include tests 


Ensure that it works on another machine 

The scenario_context object for the step definitions is the bridge for the driver from the hooks to the step definitions- discuss how we are setting this in the hooks and referencing it in the step definitions. 
The page object can be housed in the scenario context as well. 