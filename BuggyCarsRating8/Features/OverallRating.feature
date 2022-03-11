Feature: OverallRating
	List Overall Top Five Cars

@mytag
Scenario: List Overall Top Five Cars
	Given I open the home page
	When I click Overall Rating
	Then the Overall Top Five Cars are displayed