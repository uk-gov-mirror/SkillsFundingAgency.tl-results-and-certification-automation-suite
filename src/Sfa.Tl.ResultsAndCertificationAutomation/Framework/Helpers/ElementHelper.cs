﻿using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using WaitHelpers = SeleniumExtras.WaitHelpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class ElementHelper : Hooks.Hooks
    {
        public static bool IsPresent(By by)
        {
            try
            {
                WebDriver.FindElement(by);
                return true;
            }
            catch (Exception)
            { return false; }
        }

        public static bool IsDisplayed(By by)
        {
            try
            {
                var result = WebDriver.FindElement(by);
                return result.Displayed;
            }
            catch (Exception)
            { return false; }
        }

        public static void FindElementContainingText(string text)
       {
            WebDriver.FindElement(By.XPath($"//*[contains(text(),'{text}')]"));
       }

        public static void FindAnyAnchorLinkingToUrl(string url)
       {
           WebDriver.FindElement(By.XPath($"//*[contains(text(),'{url}')]"));
       }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public static void ClickElement(By locator)
        {
            WebDriver.FindElement(locator).Click();
        }

        public static void ClearText(By locator)
        {
            WebDriver.FindElement(locator).Clear();
        }

        public static void EnterText(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void EnterText(By locator, string text)
        {
            WebDriver.FindElement(locator).Clear();
            WebDriver.FindElement(locator).SendKeys(text);
        }

        public static void EnterText(IWebElement element, int value)
        {
            if (element != null)
            {
                element.Clear();
                element.SendKeys(value.ToString());
            }
        }

        public static void PressTabKey()
        {
            IWebElement element = WebDriver.FindElement(By.TagName("body"));
            element.SendKeys(Keys.Tab);
        }

        public static void SelectFromDropDownByValue(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void SelectFromDropDownByValue(By locator, string value)
        {
            IWebElement element = WebDriver.FindElement(locator);
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void SelectFromDropDownByText(By locator, string value)
        {
            IWebElement element = WebDriver.FindElement(locator);
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        public static void SelectFromDropDownByText(IWebElement element, string text)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public static void SelectCheckBox(IWebElement element)
        {
            if (element != null && (element.Displayed && !element.Selected))
            {
                element.Click();
            }
        }

        public static void SelectCheckBox(By locator)
        {
            IWebElement element = WebDriver.FindElement(locator);
            SelectCheckBox(element);
        }

        public static void SelectRadioOptionByForAttribute(By locator, string forAttribute)
        {
            IList<IWebElement> radios = WebDriver.FindElements(locator);
            var radioToSelect = radios.FirstOrDefault(radio => radio.GetAttribute("for") == forAttribute);

            if (radioToSelect != null)
                ClickElement(radioToSelect);
        }

        public static void PressEnter()
        {
            IWebElement element = WebDriver.FindElement(By.TagName("body"));
            element.SendKeys(Keys.Enter);
        }

        public static void ClickButtonByName(string buttonName)
        {
            var buttonElement = WebDriver.FindElement(By.Name(buttonName));
            buttonElement.Click();
        }
        public static void ClickButton(By id)
        {
            IWebElement button = WebDriver.FindElement(id);
            button.Click();
        }

        public static IWebElement WaitForElement(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return WebDriver.FindElement(by);
        }

        public static void WaitForElementVisible(By by, int timeInSec)
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeInSec));
            wait.Until(WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public static void UploadFile(By by, string filename)
        {
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{filename}";
            WebDriver.FindElement(by).SendKeys(filepath);
        }

        public static void NavigateTo(string pageUrl)
        {
            string url = string.Concat(StartPage.StartPageUrl, pageUrl);  // Todo: rename StartpageUrl to BasepageUrl
            WebDriver.Navigate().GoToUrl(url);
        }
        public static void NavigateToUrl(string pageUrl)
        {
            WebDriver.Navigate().GoToUrl(pageUrl);
        }

        public static IList<IWebElement> GetElementsByClassName(string classname)
        {
            var elements = WebDriver.FindElements(By.ClassName(classname)) ;
            return elements;
        }

        public static void ClickLinkByLabel(string label)
        {
            var linkWithLabel = By.LinkText(label);
            ClickElement(linkWithLabel);
        }
    }
}
