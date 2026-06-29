using OpenQA.Selenium;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void Click(By by)
        {
            WaitHelper.WaitForElementClickable(driver, by);
            driver.FindElement(by).Click();
        }

        protected void Type(By by, string text)
        {
            WaitHelper.WaitForElementVisible(driver, by);
            driver.FindElement(by).SendKeys(text);
        }
    }
}
