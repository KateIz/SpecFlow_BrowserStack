Feature: DemoQA_Page

@mytag
Scenario: Open the HomePage
	Given Go to page
	Then I should see DemoQA page
	When I click Text box section
	And I fill in the form
	And I click Submit
	Then I should see confirmation below the form




#1. zamykanie chromWebdriver
#2. zamykanie strony
#3. zmienic nazwę feature file
#4. stworzyc klase init webdrider
#5. otwierać przeglądarkę zmakwsymilizowaną w trybie incognito
#6.
	
	