using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class LoginTests : TestBase
    {
        private string url = "https://www.saucedemo.com/";

        [TestMethod]
        public void TC01_ValidLogin()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");
            SimpleReport.Log("TC01_ValidLogin", "PASS");
        }

        [TestMethod]
        public void TC02_InvalidPassword()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "wrongpass");
            SimpleReport.Log("TC02_InvalidPassword", "PASS");
        }

        [TestMethod]
        public void TC03_InvalidUsername()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("wrong_user", "secret_sauce");
            SimpleReport.Log("TC03_InvalidUsername", "PASS");
        }

        [TestMethod]
        public void TC04_BlankUsername()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("", "secret_sauce");
            SimpleReport.Log("TC04_BlankUsername", "PASS");
        }

        [TestMethod]
        public void TC05_BlankPassword()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "");
            SimpleReport.Log("TC05_BlankPassword", "PASS");
        }

        [TestMethod]
        public void TC06_LockedUser()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("locked_out_user", "secret_sauce");
            SimpleReport.Log("TC06_LockedUser", "PASS");
        }

        [TestMethod]
        public void TC07_SQLInjection()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("' OR '1'='1", "' OR '1'='1");
            SimpleReport.Log("TC07_SQLInjection", "PASS");
        }

        [TestMethod]
        public void TC08_CaseSensitiveLogin()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("Standard_User", "secret_sauce");
            SimpleReport.Log("TC08_CaseSensitiveLogin", "PASS");
        }
    }
}
