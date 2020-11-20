Feature: Test2
		Search on the site


@smoke
Scenario: User can search product on site
	Given User is on Main page
	And User enter the following detail on search bar
	| Product |
	| jeans   |
	When User press enter
	Then User can se entered product