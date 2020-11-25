Feature: Tets 3
	If you entered nothing and just clicked search the nothing should occur.


@mytag
Scenario: Click on search icon without text on box
	Given Open Google Chrome browser
	And Entered nothing  
	When Search button
	Then Nothing should occur