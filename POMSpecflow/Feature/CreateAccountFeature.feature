Feature: CreateAccountFeature
	


@mytag
Scenario: Create An Account
	Given Client is on the website
	And client enter the Email
	When client click the Create an account button
	Then Client navigate to create account form
