Feature: Test3
		More information about one concret product

@mytag
Scenario: User can see more information about one concret product
	Given User is on main Page
	And User click Women's wear compartiment
	And User choose Women Clothing part
	When User choose Black Basic Shorts Product 
	Then Black Basic Shorts Product is open