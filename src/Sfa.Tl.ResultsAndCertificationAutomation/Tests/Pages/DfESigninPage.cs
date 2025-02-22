﻿using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static readonly string DfeInvalidUserName = "test@tleveltest.com";
        private static readonly string AOAdminUser = WebDriverFactory.Config["AOAdminUser"];
        private static readonly string PearsonAdminUser = WebDriverFactory.Config["PearsonAdminUser"];
        private static readonly string AOAllUser = WebDriverFactory.Config["AOAllUser"];
        private static readonly string AORevProvUser = WebDriverFactory.Config["APRevProUser"];
        private static readonly string AOReviewerUser = WebDriverFactory.Config["AOReviewer"];
        private static readonly string AOProviderUser = WebDriverFactory.Config["AOProviderEditor"];
        private static readonly string AORegistrationUser = WebDriverFactory.Config["AORegistrationEditor"];
        private static readonly string AOResultsUser = WebDriverFactory.Config["AOResultsEditor"];
        private static readonly string AONoRoleUser = WebDriverFactory.Config["AONoRole"];
        private static readonly string AONoServiceUser = WebDriverFactory.Config["AONoService"];
        public static readonly string AOAppPassword = WebDriverFactory.Config["AOPassword"];
        public static readonly string ProBarnsleyPA = WebDriverFactory.Config["ProBarnsleyPA"];
        public static readonly string ProBarnsleyLRE = WebDriverFactory.Config["ProBarnsleyLRE"];
        public static readonly string ProBarnsleyAll = WebDriverFactory.Config["ProBarnsleyAll"];
        public static readonly string ProCardinalPA = WebDriverFactory.Config["ProCardinalPA"];
        public static readonly string ProCardinalLRE = WebDriverFactory.Config["ProCardinalLRE"];
        public static readonly string ProCardinalAll = WebDriverFactory.Config["ProCardinalAll"];
        public static readonly string ProDudleyPA = WebDriverFactory.Config["ProDudleyPA"];
        public static readonly string ProDudleyLRE = WebDriverFactory.Config["ProDudleyLRE"];
        public static readonly string ProDudleyAll = WebDriverFactory.Config["ProDudleyAll"];
        public static readonly string ProUserPassword = WebDriverFactory.Config["ProUserPassword"];
        public static string DashboardUrl = string.Concat(StartPage.StartPageUrl, "home");
        public static readonly By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public const string SigninError = "Information missing or incorrect";
        protected static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        public static By UserIdTxtBox { get; } = By.Id("username");
        public static By PasswordTxtBox { get; } = By.Id("password");
        public static By StartNowButton { get; set; } = By.XPath("//a[@role='button' and contains(text(),'Start now')]");
        public By DfESignInErrorMessage { get; set; } = By.Id("error-summary");
        public static By ManageTlevelHeader = By.XPath("//a[contains(text(),'Manage T Level results')]");

        public static void DfESignIn(string username, string password)
        {
            WebDriver.FindElement(UserIdTxtBox).SendKeys(username);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(password);
            WebDriver.FindElement(SignInButton).Click();
        }

        public static void TLevelSignIn(string username, string password)
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            PageHelper.WaitForPageElementBy(10, UserIdTxtBox);
            WebDriver.FindElement(UserIdTxtBox).SendKeys(username);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(password);
            PageHelper.WaitForPageElementBy(10, SignInButton);
            WebDriver.FindElement(SignInButton).Click();
            PageHelper.WaitForUrl(DashboardUrl);
        }

        public static void SigninAsAOApprover()
        {
            TLevelSignIn(AOAdminUser, AOAppPassword);
        }

        public static void SigninAsAOCentre()
        {
            TLevelSignIn(AOReviewerUser, AOAppPassword);
        }

        public static void SigninAsSiteAdmin()
        {
            TLevelSignIn(AOAdminUser, AOAppPassword);
        }
        public static void SigninAsPearsonSiteAdmin()
        {
            TLevelSignIn(PearsonAdminUser, AOAppPassword);
        }

        public static void SigninAsAllUser()
        {
            TLevelSignIn(AOAllUser, AOAppPassword);
        }

        public static void SigninAsRevProvUser()
        {
            TLevelSignIn(AORevProvUser, AOAppPassword);
        }
        public static void SigninAsReviewer()
        {
            TLevelSignIn(AOReviewerUser, AOAppPassword);
        }
        public static void SigninAsProvider()
        {
            TLevelSignIn(AOProviderUser, AOAppPassword);
        }
        public static void SigninAsRegistrationEditor()
        {
            TLevelSignIn(AORegistrationUser, AOAppPassword);
        }
        public static void SigninAsResultsEditor()
        {
            TLevelSignIn(AOResultsUser, AOAppPassword);
        }

        public static void SigninAsNoRoleNoServiceUser()
        {
            TLevelSignIn(AONoRoleUser, AOAppPassword);
        }
        public static void SigninAsProviderBarnsleyPAUser()
        {
            TLevelSignIn(ProBarnsleyPA, ProUserPassword);
        }
        public static void SigninAsProviderBarnsleyLREUser()
        {
            TLevelSignIn(ProBarnsleyLRE, ProUserPassword);
        }
        public static void SigninAsProviderBarnsleyAllUser()
        {
            TLevelSignIn(ProBarnsleyAll, ProUserPassword);
        }
        public static void SigninAsProviderCardinalPAUser()
        {
            TLevelSignIn(ProCardinalPA, ProUserPassword);
        }
        public static void SigninAsProviderCardinalLREUser()
        {
            TLevelSignIn(ProCardinalLRE, ProUserPassword);
        }
        public static void SigninAsProviderCardinalAllUser()
        {
            TLevelSignIn(ProCardinalAll, ProUserPassword);
        }
        public static void SigninAsProviderDudleyPAUser()
        {
            TLevelSignIn(ProDudleyPA, ProUserPassword);
        }
        public static void SigninAsProviderDudleyLREUser()
        {
            TLevelSignIn(ProDudleyLRE, ProUserPassword);
        }
        public static void SigninAsProviderDudleyAllUser()
        {
            TLevelSignIn(ProDudleyAll, ProUserPassword);
        }
        public static void SigninAsNoServiceUser()
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            WebDriver.FindElement(UserIdTxtBox).SendKeys(AONoServiceUser);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(AOAppPassword);
            WebDriver.FindElement(SignInButton).Click();
            PageHelper.WaitForUrl(StartPage.Error403);
        }
    }
}
