Feature: Test4
	If a person has searched irrelevant, 
	it should display the “Did you mean” link.

@mytag
Scenario: Person insert irrelevant text and Did you mean link should be display
	Given Open Chrome browser
	And Enter irrelevant text 
	When Press search button
	Then Link Did you mean displayed