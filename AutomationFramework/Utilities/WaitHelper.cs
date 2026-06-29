using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers; // Make sure Selenium.Support installed
using System;

namespace SwagLabsAutomation.Utilities
{
    public static class WaitHelper
    {
        // 1️⃣ Wait for element to exist in DOM
        public static IWebElement WaitForElement(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(d => d.FindElement(locator));
        }

        // 2️⃣ Wait for element to be visible
        public static IWebElement WaitForElementVisible(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        // 3️⃣ Wait for element to be clickable
        public static IWebElement WaitForElementClickable(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
