﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsSearchPage : ElementHelper
    {
        private static readonly string SearchResultUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-registration-details");
        private static readonly string CancelRegUrl = string.Concat(StartPage.StartPageUrl, "cancel-registration");
        private static readonly string CancelRegSuccessUrl = string.Concat(StartPage.StartPageUrl, "registration-cancelled-confirmation");
        private static readonly string UlnNotFoundUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-ULN-not-found");
        public static readonly By SearchRegistrationLink = By.XPath("//a[contains(text(),'Search for a registration')]");
        public static readonly By SearchBox = By.Id("searchuln");
        public static readonly By SearchBtn = By.XPath("//button[contains(text(),'Search')]");
        private static readonly By CancelRegBtn = By.XPath("//a[contains(text(),'Cancel this registration')]");
        private static readonly By CancelRegYes = By.Id("cancelregistration");
        public static By BackToRegistrationDetailsBtn { get; } = By.XPath("//a[contains(text(),'Back to registration details')]");
        public static By CancelRegNo { get; } = By.Id("cancel-registration-no");
        private static readonly By SubmitBtn = By.XPath("//button[contains(text(),'Submit')]");
        private static readonly By SearchAnotherRegBtn = By.XPath("//a[contains(text(),'Search for another registration')]");
        private static readonly string ConfirmRegCancelTitle = "Cancel registration page – Manage T Level results – GOV.UK";
        private static readonly string ConfirmRegCancelHeader = "Are you sure you want to cancel this registration?";
        private static readonly string CancelRegSuccessTitle = "Registration cancelled confirmation page – Manage T Level results – GOV.UK";
        private static readonly string CancelRegSuccessHeader = "Registration cancelled successfully";
        private static readonly string UlnNotFoundTitle = "ULN cannot be found page – Manage T Level results – GOV.UK";
        public static string ConfirmRegCancelErrorTitle = "Error: Cancel registration page – Manage T Level results – GOV.UK";
        public const string ChangeProviderPageTitle = "Change provider page – Manage T Level results – GOV.UK";
        public static readonly string ChangeProviderUrl = string.Concat(StartPage.StartPageUrl, "change-provider");
        public static readonly string ChangeProviderPageHeader = "Select the provider";
        public const string ChangeRegistrationSuccessPageTitle = "Registration details change confirmation page – Manage T Level results – GOV.UK";
        public static readonly string ChangeRegistrationSuccessPageUrl = string.Concat(StartPage.StartPageUrl, "registration-details-change-confirmation");
        public static readonly string ChangeRegistrationSuccessHeader = "Change successful";
        public const string CannotChangeProviderPageTitle = "Cannot change provider page – Manage T Level results – GOV.UK";
        public static readonly string CannotChangeProviderPageUrl = string.Concat(StartPage.StartPageUrl, "cannot-change-provider");
        public static By CancelRegError { get; } = By.XPath("//a[@href='#cancelregistration']");
        public static string CancelRegErrorDeails { get; } = "Select yes if you want to cancel this registration";
        public static By ChangeBtn { get; } = By.XPath("//button[contains(text(),'Change')]");
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By ULNStatus { get; } = By.XPath("//*[@id='main-content']//strong");
        private static By NameChangeLink { get; } = By.Id("learnername");
        private static By DOBChangeLink { get; } = By.Id("dateofbirth");
        public static By ProviderChangeLink { get; } = By.Id("provider");
        private static By CoreChangeLink { get; } = By.Id("core");
        private static By SpecialismChangeLink { get; } = By.Id("specialisms");
        private static By AcademicYearChangeLink { get; } = By.Id("academicyear");

        public static void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifySearchResultPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SearchResultUrl));
            Assert.AreEqual(Constants.SearchDetailsTitle, WebDriver.Title);
            Assert.AreEqual(Constants.SearchDetailsHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyName(string name) 
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
        }
        public static void VerifyDob(string Dob)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Dob));
        }
        public static void VerifyProvider(string Provider)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Provider));
        }
        public static void VerifyCore(string Core)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Core));
        }
        public static void VerifySpecialism(string Specialism)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Specialism));
        }
        public static void ClickCancelRegistration()
        {
            ClickButton(CancelRegBtn);
        }
        public static void VerifyConfirmRegCancelPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(CancelRegUrl));
            Assert.AreEqual(ConfirmRegCancelTitle, WebDriver.Title);
            Assert.AreEqual(ConfirmRegCancelHeader, WebDriver.FindElement(By.XPath("//*[@id='main-content']//h1")).Text);
        }
        public static void VerifyCancelRegistrationPage()
        {
            ClickButton(CancelRegBtn);
        }
        public static void YesToCancelReg()
        {
            ClickElement(CancelRegYes);
            ClickButton(SubmitBtn);
        }
        public static void VerifyRegCancelSuccessPage()
        {
            Assert.AreEqual(CancelRegSuccessUrl,WebDriver.Url);
            Assert.AreEqual(CancelRegSuccessTitle, WebDriver.Title);
            Assert.AreEqual(CancelRegSuccessHeader, WebDriver.FindElement(By.XPath("//*[@id='main-content']//h1")).Text);
        }
        public static void SearchAnotherReg()
        {
            ClickButton(SearchAnotherRegBtn);
        }
        public static void VerifyUlnNotFoundPage(string uln)
        {
            Assert.AreEqual(UlnNotFoundTitle, WebDriver.Title);
            Assert.AreEqual(UlnNotFoundUrl, WebDriver.Url);
            Assert.AreEqual("ULN (" + uln + ") cannot be found", WebDriver.FindElement(By.XPath("//*[@id='main-content']//h1")).Text);
        }
        public static void VerifySearchFromBulkUpload()
        {
            VerifyName("First Name 1 Last Name 1");
            VerifyDob("10/01/2006");
            VerifyProvider("Automation Test1 (99999901)");
            VerifyCore("Agriculture, Environmental and Animal Care (77777777)");
            VerifySpecialism("Animal Care and Management (70000001)");
        }


        public static void UlnStatus()
        {
            Assert.AreEqual("ACTIVE", WebDriver.FindElement(ULNStatus).Text);
        }

        public static void ValidateChangeLinks()
        {
            Assert.IsTrue(WebDriver.FindElement(NameChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(DOBChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(ProviderChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(CoreChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(SpecialismChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(AcademicYearChangeLink).Text.Contains("Change"));
        }
        public static void VerifyChangeSuccessPage()
        {
            Assert.AreEqual(ChangeRegistrationSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeRegistrationSuccessPageUrl, WebDriver.Url);
            Assert.AreEqual(ChangeRegistrationSuccessHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
