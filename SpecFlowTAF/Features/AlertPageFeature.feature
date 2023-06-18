Feature: AlertPageFeature

Testing Alerts

@tag1
Scenario: Check if alert is present
	Given User navigate to webpage "https://testpages.herokuapp.com/styled/alerts/alert-test.html"
	When User trigger alert
	Then Alert is present

@tag1
Scenario: Check if alert is not present
	Given User navigate to webpage "https://testpages.herokuapp.com/styled/alerts/alert-test.html"
	When User not trigger alert
	Then Alert is not present
