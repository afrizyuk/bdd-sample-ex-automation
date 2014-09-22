Feature: FileAccessFeature
	In order to share my files
	As a new user
	I want to able to work with my files functionality

Scenario: Create Storage
	Given I'm on the main ex.ua page
	When I create new files storage
	Then the new storage edit page should be opened


Scenario: Files Upload
	Given I'm on the main ex.ua page
	When I create new files storage
	And I uploaded new files:
	| FilePath                          |
	| C:\mount_export.gcode             |
	Then files should be marked as loaded:
	| FileName                       |
	| mount_export.gcode             |
	

Scenario: Storage Delete
	Given I'm on the main ex.ua page
	When I create new files storage
	And I go on the main ex.ua page
	And I try to get access to the storage by pageurl
	And I delete the storage
	And I try to get access to the storage by access key
	Then the storage is not found

Scenario: Get access by new created key
    Given I'm on the main ex.ua page
	When I create new files storage
	And I go on the main ex.ua page
	And I try to get access to the storage by access key
	Then I'm got access to the storage

Scenario Outline: Get access by existing key
	Given I'm on the main ex.ua page
	And I try to get access to the storeage by access key <key>
	Then I'm got access to the storage
Examples: 
	| key          |
	| 699685368588 |
	| 409086139215 |

Scenario: Get access by url
	Given I'm on the main ex.ua page
	When I create new files storage
	And I go on the main ex.ua page
	And I try to get access to the storage by pageurl
	Then I'm got access to the storage