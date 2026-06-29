using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class CartTests : TestBase
    {
        private string url = "https://www.saucedemo.com/";

        [TestMethod]
        public void TC18_AddToCart()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            SimpleReport.Log("TC18_AddToCart", "PASS");
        }

        [TestMethod]
        public void TC19_RemoveItem()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");

            var cart = new CartPage(driver);
            cart.OpenCart();
            cart.RemoveItem("Sauce Labs Backpack");

            SimpleReport.Log("TC19_RemoveItem", "PASS");
        }

        [TestMethod]
        public void TC20_UpdateQuantity()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");

            var cart = new CartPage(driver);
            cart.OpenCart();
            cart.UpdateQuantity("Sauce Labs Backpack", 2);

            SimpleReport.Log("TC20_UpdateQuantity", "PASS");
        }

        [TestMethod]
        public void TC21_EmptyCart()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var cart = new CartPage(driver);
            cart.EmptyCart();

            SimpleReport.Log("TC21_EmptyCart", "PASS");
        }

        [TestMethod]
        public void TC22_VerifyCartCount()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");

            var cart = new CartPage(driver);
            cart.VerifyCartCount(1);

            SimpleReport.Log("TC22_VerifyCartCount", "PASS");
        }

        [TestMethod]
        public void TC23_VerifyTotalAmount()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");
            products.AddToCart("Sauce Labs Bike Light");

            var cart = new CartPage(driver);
            cart.VerifyTotalAmount(29.99 + 9.99); // example prices

            SimpleReport.Log("TC23_VerifyTotalAmount", "PASS");
        }

        [TestMethod]
        public void TC24_AddMultipleItems()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");
            products.AddToCart("Sauce Labs Bolt T-Shirt");

            var cart = new CartPage(driver);
            cart.OpenCart();

            SimpleReport.Log("TC24_AddMultipleItems", "PASS");
        }

        [TestMethod]
        public void TC25_VerifyCartPersistence()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddToCart("Sauce Labs Backpack");

            driver.Navigate().Refresh();

            var cart = new CartPage(driver);
            cart.VerifyCartCount(1);

            SimpleReport.Log("TC25_VerifyCartPersistence", "PASS");
        }
    }
}
