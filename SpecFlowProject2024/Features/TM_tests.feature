Feature: This test suite contains test scenarios for the following

1. Create TM Record
2. Edit TM Record
3. Deelete TM Record

Scenario: verify user is able to create new TM Record
Given user logs into turnup portal
And user navigates to the TM Redord
When user creates a new TM Record
Then System should save the New TM Record

Scenario: verify user is able to edit new TM record
Given user logs into turnup portal
And user navigates to the turnup portal
When user creates a new TM Record
Then Record should be updated

Scenario: verify user is able to delete the new TM record
Given user logs into turnup portal
And user navigates to turnup portal
When user deletes a new TM Record
Then record should be deleted
