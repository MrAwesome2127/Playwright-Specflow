Feature: Add Game to Cart

@mytag
Scenario: Add Physical Game to Cart
	Given I search for Product
	When I select a Physical copy
		And I add a Physical copy to my cart
	Then I validate my cart has a Physical copy