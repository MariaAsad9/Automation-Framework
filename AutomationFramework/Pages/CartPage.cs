using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Open the cart page
        public void OpenCart()
        {
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
        }

        public void RemoveItem(string productName)
        {
            driver.FindElement(By.XPath($"//div[text()='{productName}']/ancestor::div[@class='cart_item']//button")).Click();
        }

        public void UpdateQuantity(string productName, int quantity)
        {
            var qtyInput = driver.FindElement(By.XPath($"//div[text()='{productName}']/ancestor::div[@class='cart_item']//input"));
            qtyInput.Clear();
            qtyInput.SendKeys(quantity.ToString());
        }

        public void EmptyCart()
        {
            var removeButtons = driver.FindElements(By.CssSelector(".cart_item .cart_button"));
            foreach (var btn in removeButtons)
            {
                btn.Click();
            }
        }

        public void VerifyCartCount(int expectedCount)
        {
            var cartBadge = driver.FindElement(By.ClassName("shopping_cart_badge"));
            int actualCount = int.Parse(cartBadge.Text);
            if (actualCount != expectedCount) throw new System.Exception($"Cart count mismatch. Expected {expectedCount}, got {actualCount}");
        }

        public void VerifyTotalAmount(double expectedAmount)
        {
            double total = 0;
            var prices = driver.FindElements(By.CssSelector(".cart_item .inventory_item_price"));
            foreach (var p in prices)
            {
                string text = p.Text.Replace("$", "");
                total += double.Parse(text);
            }
            if (total != expectedAmount) throw new System.Exception($"Cart total mismatch. Expected {expectedAmount}, got {total}");
        }

        public void ClickCheckout()
        {
            driver.FindElement(By.Id("checkout")).Click();
        }
    }
}
