Feature: PopularMake
	List Top 5 Models of the Popular Make

@mytag
Scenario: List Top 5 Models of the Popular Make
	Given I open the home page
	When I click Popular Make
	Then the Top Five models of the Popular Make are displayed