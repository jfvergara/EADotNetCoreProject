Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@kimbo
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@kimbo
Scenario: Rest two numbers
	Given the first number is 100
	And the second number is 70
	When the two numbers are rested
	Then the result should be 30