Feature: Facebook
	

@SmokeTest
@Browser:Chrome
Scenario: Facebook login Page
	Given The User Navigates to facebook
	When The user enters correct username
	When The user enters correct password
	Then the user should be logged in  



	