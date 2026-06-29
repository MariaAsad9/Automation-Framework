using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class ProductsTests : TestBase
    {
        private string url = "https://www.saucedemo.com/";

        [TestMethod]
        public void TC09_AddFirstProductToCart()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            SimpleReport.Log("TC09_AddFirstProductToCart", "PASS");
        }

        [TestMethod]
        public void TC10_AddSpecificProductToCart()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");
            products.OpenCart();

            SimpleReport.Log("TC10_AddSpecificProductToCart", "PASS");
        }

        [TestMethod]
        public void TC11_SearchExistingProduct()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.SearchProduct("Sauce Labs Backpack");
            SimpleReport.Log("TC11_SearchExistingProduct", "PASS");
        }

        [TestMethod]
        public void TC12_SearchNonExistingProduct()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.SearchProduct("XYZ123");
            SimpleReport.Log("TC12_SearchNonExistingProduct", "PASS");
        }

        [TestMethod]
        public void TC13_AddFromDetailsPage()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCartFromDetailsPage("Sauce Labs Backpack");
            products.OpenCart();

            SimpleReport.Log("TC13_AddFromDetailsPage", "PASS");
        }

        [TestMethod]
        public void TC14_VerifyCartCount()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.VerifyCartCount(1);

            SimpleReport.Log("TC14_VerifyCartCount", "PASS");
        }

        [TestMethod]
        public void TC15_ViewProductDetails()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.ViewProductDetails("Sauce Labs Backpack");

            SimpleReport.Log("TC15_ViewProductDetails", "PASS");
        }

        [TestMethod]
        public void TC16_AddMultipleProducts()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");
            products.AddToCart("Sauce Labs Bike Light");

            SimpleReport.Log("TC16_AddMultipleProducts", "PASS");
        }

        [TestMethod]
        public void TC17_SearchPartialKeyword()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.SearchProduct("Sauce");
            SimpleReport.Log("TC17_SearchPartialKeyword", "PASS");
        }
    }
}
