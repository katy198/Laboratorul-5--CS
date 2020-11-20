Feature: Test1
	Sign Up to site

@smoke
Scenario: User can Sing Up with valid credentials
    #steps
	Given User is on main page
    And User clicks on 'Sign Up' link
    And User enter the following detail
        | Name      | Email                         | Password     | ConfirmPassword |
        | Ecaterina | ecaterina.pavlenco@ati.utm.md | ecaterina123 | ecaterina123 |
    When User clicks on SignUp
    Then User is registered successfully

    