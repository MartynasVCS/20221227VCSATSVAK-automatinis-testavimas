using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        internal static void Wait(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }

        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void ScrollBy(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static string GetCssValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }
    }
}
