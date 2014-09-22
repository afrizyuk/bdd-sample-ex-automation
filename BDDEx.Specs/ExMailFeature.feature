Feature: ExMailFeature
	In order to keep privacy
	As a new user
	I want to use ex-mail

Scenario Outline: Create account
	Given I'm on the main ex.ua page
	And I want to use ex-mail
	And I want to create new account
	When I enter data for registration <login,Password,EULA>
	And Press register
	Then My account is registered
	And Inbox is opened
		
	Examples: 
	| Login     | Password | EULA  |
	| SomeLogin | P@ssword | check |

Scenario: User login
	Given I'm on the main ex.ua page
	And I want to use ex-mail
	When I enter username and password
	And Press Login
	Then Inbox is opened

Scenario: User logout
	Given I'm authorized ex-mail user
	When Press Logout
	Then I'm logged out

Scenario: Send email
	Given I'm authorized ex-mail user
	And I want to send an email
	When I input my address to the recipient address field
	And I input email topic 'topic'
	And I input email body 'body'
	And I press Send
	Then Inbox should contain new email

Scenario: Delete email
	Given I'm authorized user
	And I have at least one email at inbox
	When I select an email
	And press delete
	Then the email should be in the recycle bin