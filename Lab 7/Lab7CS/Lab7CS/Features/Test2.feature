Feature: Tets2
		 Check how many results display on a single page.


@mytag
Scenario: Count displayed results after texting
	Given Open Browser
	And Enter some text
	And Press Enter
	When Count results
	Then Entered in console number of results