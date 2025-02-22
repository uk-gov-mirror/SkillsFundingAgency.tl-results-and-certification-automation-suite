﻿Feature: 1879_Create Learner's Assessment Entries Page
	As a Registrations Editor
	I need to be able to view Assessment Entry details for students
	So that I can ensure they are up to date

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I upload registrations and associated assessments

@RegressionTest @AssessmentEntries
Scenario: 1879_Click the 'View and amend this learner’s registration details' link to navigate to the registration details page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
When I click the 'View and amend this learner’s registration details' link
Then I am navigated to the Registration Details page for the learner's <ULN>
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000004  |

@RegressionTest @AssessmentEntries
Scenario: 1879_Click the Search again details' link to navigate to the 'Search for a learner' page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
When I click the Search again link on the learners assessment entries page
Then I am navigated back to the Search for a learner page 
And the Search for a learner page search entry will not be retained
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000004  |


@RegressionTest @AssessmentEntries
Scenario: 1879_Validate breadcrumb links on the Learner's Assessment Entries page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
When I press the Assessment Entries breadcrumb link on the Assessment Entries Learner page
Then I am navigated to the Assessment Entries page
Given I navigate to the Search for a learner page and enter the <ULN>
And I press the Home breadcrumb link on the Assessment Entries Learner page
Then I am taken to the home page
Given I navigate to the Search for a learner page
And I enter the following <ULN>
And I press the Search for a learner breadcrumb link on the Assessment Entries Learner page
Then I am navigated back to the Search for a learner page
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000004  |


@RegressionTest @AssessmentEntries
Scenario: 2138_Replace 'Assessment entry' for Core and Specialism with 'First assessment entry'
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core and Specialism is displayed in grey text
And the core and specialism heading displays 'First assessment entry'
And the text 'Available to add after Autumn 2021 series has passed' is displayed for the Specialism
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000004  |