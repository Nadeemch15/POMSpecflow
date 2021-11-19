#tag represent collection of test cases
@regression

Feature: CreateAccountFeature
		This account is created to access the website

#common steps	
Background: 
	Given Client is on the website 

Scenario Outline: Create An Account
	
	And client enter the email "<Email>"
	When client click the Create an account button
	Then Client navigate to create account form

	
	Examples: 
|  Email				|
|  rest100@email.com	|
|  rest101@email.com	|

	Scenario: Register client	
	And client filled the form
	When client click Register button
	Then client successfully registered



#@smock single test case
	Scenario: Registeration client
	
	And client filled the form
	When client click Register button
	Then client successfully registered


