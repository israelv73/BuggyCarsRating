Feature: Login
	Login to Buggy Cars Rating website

@mytag

Scenario: Successful login
	Given I open the home page
	When I login with valid Login and Password
	Then 'Hi' message is displayed
