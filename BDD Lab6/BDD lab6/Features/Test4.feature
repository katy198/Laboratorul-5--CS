Feature: Test4
	Acces Facebook social media  

@mytag
Scenario: User can acces store's social media
	Given User is on Main Page
	And User scroll to the footer
	When User acces Facebook social media
	Then User is redirected to store's page in Facebook 