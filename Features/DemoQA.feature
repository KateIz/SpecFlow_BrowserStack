Feature: DemoQA_Page

@mytag
Scenario: Open the HomePage
	Given Go to page '<url>'
	Then I should see '<url>'
	When I click Text box section
	And I fill in the form
	And I click Submit
	Then I should see the Name in the form Name
	And I should see the Email in the form Email
	And I should see the Adress in the form Adress

	Examples: 
	| url                 |
	| https://demoqa.com/ |





	
	