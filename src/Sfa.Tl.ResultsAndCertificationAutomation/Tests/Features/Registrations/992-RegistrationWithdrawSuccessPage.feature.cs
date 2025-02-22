﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Registrations
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create Learner Withdrawn Successfully Page - Story 992")]
    public partial class CreateLearnerWithdrawnSuccessfullyPage_Story992Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "992-RegistrationWithdrawSuccessPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/Registrations", "Create Learner Withdrawn Successfully Page - Story 992", "     As a Registrations Editor\r\n     I need to be able to see that I have withdra" +
                    "wn a student\r\n     So that I can be assured that my action is complete", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
testRunner.Given("I have logged in as a \"RegistrationEditor\" user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
testRunner.And("I click on Add a new registration link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
testRunner.And("I create a manual registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("992_Navigate to the Registration Withdrawn Successfully page from the Change Core" +
            " Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("WithdrawRegistration")]
        public virtual void _992_NavigateToTheRegistrationWithdrawnSuccessfullyPageFromTheChangeCorePage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "WithdrawRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("992_Navigate to the Registration Withdrawn Successfully page from the Change Core" +
                    " Page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 14
testRunner.When("I click Withdraw Registration on the Change Core page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
testRunner.Then("I will be directed to the are you sure you want to withdraw this page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
testRunner.When("I select Yes, withdraw registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
testRunner.Then("I will be navigated to the Registration withdrawn successfully page (from Change " +
                        "Core page)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("992_Navigate to the Registration Withdrawn Successfully page from the Change Prov" +
            "ider and Core Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("WithdrawRegistration")]
        public virtual void _992_NavigateToTheRegistrationWithdrawnSuccessfullyPageFromTheChangeProviderAndCorePage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "WithdrawRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("992_Navigate to the Registration Withdrawn Successfully page from the Change Prov" +
                    "ider and Core Page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 22
testRunner.When("I click Withdraw Registration on the Change Provider and Core page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
testRunner.Then("I will be directed to the are you sure you want to withdraw this page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
testRunner.When("I select Yes, withdraw registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
testRunner.Then("I will be navigated to the Registration withdrawn successfully page (from Change " +
                        "Provide and Core page)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("992_Navigate to the Registration Withdrawn Successfully page from the Active Opti" +
            "ons Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("WithdrawRegistration")]
        public virtual void _992_NavigateToTheRegistrationWithdrawnSuccessfullyPageFromTheActiveOptionsPage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "WithdrawRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("992_Navigate to the Registration Withdrawn Successfully page from the Active Opti" +
                    "ons Page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 30
testRunner.When("I click Withdraw Registration on the Active Options page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
testRunner.Then("I will be directed to the are you sure you want to withdraw this page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
testRunner.When("I select Yes, withdraw registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
testRunner.Then("I will be navigated to the Registration withdrawn successfully page (From Active " +
                        "Options page)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
testRunner.When("I click the View Withdrawn Registration button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
testRunner.Then("I am navigated to the Registration Details page which shows my registration is wi" +
                        "thdrawn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("992_Click the Home button on the Registration Withdrawn Successfully page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("WithdrawRegistration")]
        public virtual void _992_ClickTheHomeButtonOnTheRegistrationWithdrawnSuccessfullyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "WithdrawRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("992_Click the Home button on the Registration Withdrawn Successfully page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 40
testRunner.When("I Withdraw my Registration starting on the Active Options page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
testRunner.Then("I will be navigated to the Registration withdrawn successfully page (From Active " +
                        "Options page)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
testRunner.When("I click the Home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
testRunner.Then("I will be navigated to the Registrations Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("992_Searching for a Withdrawn registration shows the Registration Details page re" +
            "gistration status as Withdrawn")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("WithdrawRegistration")]
        public virtual void _992_SearchingForAWithdrawnRegistrationShowsTheRegistrationDetailsPageRegistrationStatusAsWithdrawn()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "WithdrawRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("992_Searching for a Withdrawn registration shows the Registration Details page re" +
                    "gistration status as Withdrawn", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 48
testRunner.When("I click Withdraw Registration on the Change Core page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
testRunner.Then("I will be directed to the are you sure you want to withdraw this page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
testRunner.When("I select Yes, withdraw registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
testRunner.Then("I will be navigated to the Registration withdrawn successfully page (from Change " +
                        "Core page)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
testRunner.When("I search for my registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
testRunner.Then("I am navigated to the Registration Details page which shows my registration is wi" +
                        "thdrawn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
