Feature: RegisterUser
	In order to register a new user on the system
	As a new user
	I want belong to the system

@mytag
Scenario: Register a new user with correc data
	Given I have navigated to the application
	And I see application opened
	Then I click register link
	When I enter UserName, Password, ConfirmPassword, Email
	| UserName | Password  | ConfirmPassword | Email            |
	| admin2   | password2 | password2       | admin2@gmail.com |
	Then I click login button
	Then I should see the username with hello
	Then I click logout