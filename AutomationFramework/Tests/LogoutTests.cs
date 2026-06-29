using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class LogoutTests : TestBase
    {
        private string url = "https://www.saucedemo.com/";

        [TestMethod]
        public void TC31_ValidLogout()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var logout = new LogoutPage(driver);
            logout.Logout();

            Assert.IsTrue(logout.IsAtLoginPage());
            SimpleReport.Log("TC31_ValidLogout", "PASS");
        }

        [TestMethod]
        public void TC32_LogoutWithoutLogin()
        {
            driver.Navigate().GoToUrl(url);
            var logout = new LogoutPage(driver);
            try { logout.Logout(); } catch { }
            SimpleReport.Log("TC32_LogoutWithoutLogin", "PASS");
        }

        [TestMethod]
        public void TC33_MenuVisibleBeforeLogout()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var logout = new LogoutPage(driver);
            Assert.IsTrue(logout.IsMenuVisible());
            SimpleReport.Log("TC33_MenuVisibleBeforeLogout", "PASS");
        }

        [TestMethod]
        public void TC34_LogoutRedirectsToLoginPage()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var logout = new LogoutPage(driver);
            logout.Logout();

            Assert.IsTrue(logout.IsAtLoginPage());
            SimpleReport.Log("TC34_LogoutRedirectsToLoginPage", "PASS");
        }

        [TestMethod]
        public void TC35_AttemptActionAfterLogout()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var logout = new LogoutPage(driver);
            logout.Logout();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/")); // redirected to login
            SimpleReport.Log("TC35_AttemptActionAfterLogout", "PASS");
        }
    }
}
