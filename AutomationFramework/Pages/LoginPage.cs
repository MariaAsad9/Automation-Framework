using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver) { this.driver = driver; }

        private IWebElement txtUsername => driver.FindElement(By.Id("user-name"));
        private IWebElement txtPassword => driver.FindElement(By.Id("password"));
        private IWebElement btnLogin => driver.FindElement(By.Id("login-button"));

        public void Login(string username, string password)
        {
            txtUsername.Clear();
            txtUsername.SendKeys(username);
            txtPassword.Clear();
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }
    }
}
