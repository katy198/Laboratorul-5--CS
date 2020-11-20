Feature: Test5
	Usec can Contact from Contact Form 

@mytag
Scenario: User can use Contact Form
	Given User acces Main Page
	And User acces Contact link on home bar
	And User scroll to the Contact Form
	And User fill needed information 
		|Name	   |Email	   					  |Subject			 | Message								|
		|Ecaterina |ecaterina.pavlenco@ati.utm.md |Ask about product |What is the matter of the pink jacket ?| 
	When User acces button Send
	Then Message is successfully send