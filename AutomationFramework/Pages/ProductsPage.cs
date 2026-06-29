using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SwagLabsAutomation.Pages
{
    public class ProductsPage
    {
        private IWebDriver driver;
        public ProductsPage(IWebDriver driver) { this.driver = driver; }

        private IWebElement CartIcon => driver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement SearchBox => driver.FindElement(By.ClassName("react-autosuggest__input"));

        public void AddFirstProductToCart()
        {
            var firstAddBtn = driver.FindElements(By.CssSelector(".inventory_item button")).First();
            firstAddBtn.Click();
        }

        public void AddToCart(string productName)
        {
            var btn = driver.FindElements(By.CssSelector(".inventory_item"))
                .First(i => i.Text.Contains(productName))
                .FindElement(By.TagName("button"));
            btn.Click();
        }

        public void AddToCartFromDetailsPage(string productName)
        {
            var link = driver.FindElements(By.ClassName("inventory_item_name"))
                .First(i => i.Text.Contains(productName));
            link.Click();
            driver.FindElement(By.CssSelector(".btn_primary.btn_inventory")).Click();
        }

        public void SearchProduct(string productName)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(productName);
            SearchBox.SendKeys(Keys.Enter);
        }

        public void ViewProductDetails(string productName)
        {
            driver.FindElements(By.ClassName("inventory_item_name"))
                  .First(i => i.Text.Contains(productName)).Click();
        }

        public void OpenCart()
        {
            CartIcon.Click();
        }

        public void VerifyCartCount(int expectedCount)
        {
            var count = driver.FindElements(By.ClassName("cart_item")).Count;
            if (count != expectedCount)
                throw new Exception($"Cart count expected {expectedCount} but found {count}");
        }
    }
}
