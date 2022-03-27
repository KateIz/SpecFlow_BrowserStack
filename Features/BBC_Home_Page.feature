Feature: BBC_Home_Page

@mytag
Scenario: Open the HomePage
	Given Go to page
	When Accept coockies
	Then I should see BBC portal
	When I click Sign In
	And I click Register Now
	