Feature: BookStore
	Simple calculator for adding two numbers

@mytag
Scenario: Verify end to end journey from BookStore application to Amazon
	Given Go to page '<url>'
	Then I should see '<url>'
	When I click on Book Store Application section
	And I click on Git Pocket Guide
	And I click Website link
	And I accept cookies
	And I click Search
	And Add '<text>' to field
	Then I should see the book with '<text>'
	When I click on book's name
	And I click button Buy on Amazon 
	Then I verify url contains '<url1>'
	#When I click Add to Cart button
	#And I go to Cart
	#Then I verify qty in order
	#When I click Proceed to Checkout
	#Then I see Amazon Sign-In page 



	Examples: 
	| url                 | text | url1						|
	| https://demoqa.com/ | code | https://www.amazon.com/	|
