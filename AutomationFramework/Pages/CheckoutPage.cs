using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterCheckoutInfo(string firstName, string lastName, string zip)
        {
            driver.FindElement(By.Id("first-name")).SendKeys(firstName);
            driver.FindElement(By.Id("last-name")).SendKeys(lastName);
            driver.FindElement(By.Id("postal-code")).SendKeys(zip);
            driver.FindElement(By.Id("continue")).Click();
        }

        public void FinishCheckout()
        {
            driver.FindElement(By.Id("finish")).Click();
        }

        public void CancelCheckout()
        {
            driver.FindElement(By.Id("cancel")).Click();
        }
    }
}
