Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit time and material records
So that I can manage employees' time and materials successfully

@tag1
Scenario: 01) Create time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to Time and Material page
	And I create a new Time and Material record
	Then The record should be created successfully

Scenario Outline: 02) Edit existing time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to Time and Material page
	And I update '<Description>', '<Code>', '<Prices>' on an existing time and material record
	Then The record should have the updated '<Description>', '<Code>', '<Prices>'


Examples: 
| Description  | Code     | Prices	|
| Time         | test     | 20		|
| Material     | keyboard | 30		|
| EditedRecord | mouse    | 40		|

Scenario: 03) Delete the last time and material record created
	Given I logged into turnup portal successfully
	When I navigate to Time and Material page 
	And I deleted the last time and material record created
	Then The record should be deleted successfully


