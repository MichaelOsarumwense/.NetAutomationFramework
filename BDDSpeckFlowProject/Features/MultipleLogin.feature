Feature: Multiple Login   

	Scenario Outline: Multiple_Role_Signin
	Given The User Navigates tru facebook
	When I enter <username> and <password>
	Then the user can clear road

	Examples:
	| username					| password		|
	| TestAccount				| 123qweQWE!@#	| 
	| BrokerAccount				| 123qweQWE!@#	|
	| IngridN					| user1324%		|

