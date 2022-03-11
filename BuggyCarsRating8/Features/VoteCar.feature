Feature: VoteCar
	Vote Car

@mytag

Scenario: Vote Car
	Given I open the home page
	When I login with valid Login and Password
	And I click Overall Rating
	Then I can vote my favorite car
