Feature: UserCreation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Test
Scenario: New EasyJet users can be created
	Given I have reached the booking confimraiton page of the DA Funnel
	When i have completed the new user creation form
	Then i am shown as being logged on to the EasyJet website
