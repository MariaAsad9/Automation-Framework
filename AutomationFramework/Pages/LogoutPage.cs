using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class LogoutPage
    {
        private IWebDriver driver;
        public LogoutPage(IWebDriver driver) { this.driver = driver; }

        private IWebElement MenuButton => driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement LogoutLink => driver.FindElement(By.Id("logout_sidebar_link"));

        public void Logout()
        {
            MenuButton.Click();
            System.Threading.Thread.Sleep(500); // chhota wait for sidebar
            LogoutLink.Click();
        }

        public bool IsAtLoginPage()
        {
            return driver.Url.Contains("https://www.saucedemo.com/");
        }

        // ✅ New public helper
        public bool IsMenuVisible()
        {
            return MenuButton.Displayed;
        }
    }
}
