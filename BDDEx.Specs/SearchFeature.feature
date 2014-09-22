Feature: SearchFeature
	In order to quicly find media files
	As a lazy user
	I want to use search engine

Scenario: Search file
	Given I'm on the main ex.ua page
	And I want to use search
	When I enter royal to input field
	And I press search button
	Then the search result should contain royal string

Scenario: Play file
	Given I'm on the content page 'contentId'
	When I Press play button for the playable file
	Then It should playing
	When I click on the player window
	Then It should stop playing
	When I close player window
	Then It should be closed

Scenario: Download file
	Given I'm on the content page
	When I click load for the file
	Then It should downloading
	And It should be downloaded

