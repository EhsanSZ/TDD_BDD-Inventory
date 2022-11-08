@api
Feature: Inventory Management
	As A Aarehouse Keeper
	I Want To Keep Track Of My Inventory
	So That I Always Have Accurate Info About Products Stock


Scenario: Defining New Inventory
	Given I Want To Add The Following Inventory
		| Product | UnitPrice |
		| IPhone  | 1100      |
	When I Try To Define This Inventory
	Then The Inventory Should Be Created
	And It Should Be Empty

