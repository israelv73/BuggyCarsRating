Feature: Login
	Login to Buggy Cars Rating website

@mytag

#Scenario: Error on empty 'Login' field
#	Given I go to home page
#	When 'Login' and 'Password' field is empty and 'Login' button is clicked 
#	Then 'Please fill out this field' is displayed in 'Login' field

#Scenario: Error on empty 'Password' field
#Given I go to home page
#	When 'Login' field is empty
#	And 'Password' field is empty
#	And I click 'Login' button
#	Then 'Please fill out this field' is displayed in 'Password' field
#

Scenario: successful login
	Given I open the home page
	When I login with valid Login and Password
	Then 'Hello' message is displayed
