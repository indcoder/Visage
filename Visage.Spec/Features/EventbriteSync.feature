Feature: EventbriteSync
Able to sync events from Eventbrite to Visage

@Scheduling 
Scenario: All sessions are HMR
	Given that there are three sessions marked as HMR in an Eventbrite event
	When I sync event from Eventbriet into Visage
	Then there should a Karyakaram created in Visage
	And the Karyakaram should have three sessions marked as HMR