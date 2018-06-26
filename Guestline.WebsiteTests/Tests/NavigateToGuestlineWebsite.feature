Feature: Navigate To Guestline Website
	In order to provide information about my company
	As a website owner
	I want users to be able to find my website on google


Scenario: I am able to navigate to Guestline's website from Google
	Given I navigate to google home page
	And I search for Guestline
	When I open the Guestline home page result
	Then I land on Guestline's website home page
	And I can navigate back to google