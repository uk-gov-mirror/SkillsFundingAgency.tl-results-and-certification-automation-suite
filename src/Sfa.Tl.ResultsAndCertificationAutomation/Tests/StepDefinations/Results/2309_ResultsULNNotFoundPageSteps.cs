﻿using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2309ULNNotFoundPageSteps : AssessmentEntriesPage
    {

        [Then(@"I will be navigated to the Results ULN Cannot be found page for (.*)")]
        public void ThenIWillBeNavigatedToTheResultsULNCannotBeFoundPageFor(string ULN)
        {
            ResultsULNNotFoundPage.VerifyResultsULNNotFoundPage(ULN);              
        }

        [Then(@"I search for a (.*) which is not registered")]
        public void ThenISearchForAWhichIsNotRegistered(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [When(@"I click the Back link on the Results ULN cannot be found page")]
        public void WhenIClickTheBackLinkOnTheResultsULNCannotBeFoundPage()
        {
            ResultsULNNotFoundPage.ClickBackLink();
        }

        [When(@"I click the Back to Search button on the Results ULN cannot be found page")]
        public void WhenIClickTheBackToSearchButtonOnTheResultsULNCannotBeFoundPage()
        {
            ResultsULNNotFoundPage.ClickBackToSearchButton();
        }

        [Then(@"the search box will be populated with the (.*) entered originally")]
        public void ThenTheSearchBoxWillBePopulatedWithTheEnteredOriginally(string ULN)
        {
            ResultsSearchForALearnerPage.VerifySearchFieldIsPrePopulated(ULN);
        }

        [Then(@"I enter the (.*) which has been registered with another AO")]
        public void ThenIEnterTheWhichHasBeenRegisteredWithAnotherAO(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }



    }
}
