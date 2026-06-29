using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class CheckoutTests : TestBase
    {
        private string url = "https://www.saucedemo.com/";

        [TestMethod]
        public void TC26_CheckoutFlow()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            var cart = new CartPage(driver);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.EnterCheckoutInfo("Areesha", "Sohail", "12345");
            checkout.FinishCheckout();

            SimpleReport.Log("TC26_CheckoutFlow", "PASS");
        }

        [TestMethod]
        public void TC27_CheckoutEmptyFields()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            var cart = new CartPage(driver);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.EnterCheckoutInfo("", "", "");
            SimpleReport.Log("TC27_CheckoutEmptyFields", "PASS");
        }

        [TestMethod]
        public void TC28_CheckoutInvalidZip()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            var cart = new CartPage(driver);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.EnterCheckoutInfo("Areesha", "Sohail", "ABC");
            SimpleReport.Log("TC28_CheckoutInvalidZip", "PASS");
        }

        [TestMethod]
        public void TC29_CancelCheckout()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            var cart = new CartPage(driver);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.CancelCheckout();

            SimpleReport.Log("TC29_CancelCheckout", "PASS");
        }

        [TestMethod]
        public void TC30_FinishCheckout()
        {
            driver.Navigate().GoToUrl(url);
            new LoginPage(driver).Login("standard_user", "secret_sauce");

            var products = new ProductsPage(driver);
            products.AddFirstProductToCart();
            products.OpenCart();

            var cart = new CartPage(driver);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.EnterCheckoutInfo("Areesha", "Sohail", "12345");
            checkout.FinishCheckout();

            SimpleReport.Log("TC30_FinishCheckout", "PASS");
        }
    }
}
