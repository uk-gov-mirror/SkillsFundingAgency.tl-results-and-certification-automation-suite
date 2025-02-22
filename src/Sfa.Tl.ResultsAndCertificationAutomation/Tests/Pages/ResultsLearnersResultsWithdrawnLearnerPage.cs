﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsLearnersResultsWithdrawnLearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "learners-results-withdrawn-learner");
        private static readonly string PageTitle = "Learner’s results - Withdrawn learner page – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Learner's results";
        public static By ULNTextLabel { get; } = By.XPath("//*[@id='main-content']//h2");
        public static readonly string ExpectedPageTextLine1Text = "You can add, view and amend a learner's results.";
        public static By NameTextLabel { get; } = By.XPath("//*[@id='main-content']//p[1]");
        public static By ProviderTextLabel { get; } = By.XPath("//*[@id='main-content']//p[2]");
        public static By WithdrawnTextLabel { get; } = By.XPath("//*[contains(text(),'This learner')]");
        public static readonly string ExpectedWithdrawnLabelText = "This learner's registration has been withdrawn";

        public static By SearchAgainLink { get; } = By.XPath("//*[contains(text(),'Search again')]");
             
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By ResultsBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By SearchForLearnerBreadcrumb { get; } = By.Id("breadcrumb2");


        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyWithdrawnLearnersResultsPage(string ULN, string FirstName, string Surname, string Provider)
        {
            string ULNText = "ULN: " + ULN;
            string ProviderText = "Provider: " + Provider;
            string NameText = "Name: " + FirstName + " " + Surname;

            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(NameText, WebDriver.FindElement(NameTextLabel).Text);
            Assert.AreEqual(ULNText, WebDriver.FindElement(ULNTextLabel).Text);
            Assert.AreEqual(ProviderText, WebDriver.FindElement(ProviderTextLabel).Text);
            Assert.IsTrue(WebDriver.FindElement(WithdrawnTextLabel).Text.Contains(ExpectedWithdrawnLabelText));
        }

        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement((HomeBreadcrumb)).Click();
        }

        public static void ClickResultsBreadcrumb()
        {
            WebDriver.FindElement((ResultsBreadcrumb)).Click();
        }

        public static void ClickSearchAgainBreadcrumb()
        {
            WebDriver.FindElement((SearchForLearnerBreadcrumb)).Click();
        }
        public static void ClickSearchAgainLink()
        {
            WebDriver.FindElement((SearchAgainLink)).Click();
        }
    }
}
