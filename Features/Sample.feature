Feature: Sample

@shoes @regression
Scenario: Run Shoes Search Automation
	Given the application navigates to the HomePage
	And the user fills in shoes
	And the user clicks Search
	And the application navigates to the SearchResultsPage
	And the user clicks SelectFirstResult
	And the user validates the page url displays 'shoes'

@shirt @regression
Scenario: Run Shirt Search Automation
	Given the application navigates to the HomePage
	And the user fills in shirt
	And the user clicks Search
	And the application navigates to the SearchResultsPage
	And the user clicks SelectFirstResult
	And the user validates the page url displays 'shirt'