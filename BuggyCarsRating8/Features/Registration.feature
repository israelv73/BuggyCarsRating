Feature: Registration
	Registration of new users

@mytag

Scenario: Registration of new users
	Given I click the Register button
	When I enter 'QATest' 'QA' 'Test' 'P@ssw0rd!' 'P@ssw0rd!'
	And click Register button
	Then new user is registered