using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class ProductPage : BasePage
    {
        public ProductPage() : base()
        {
        }
        private readonly By _productDetailsButton = By.CssSelector(".btn-default");        private By productLinkPrefix = By.CssSelector(".product-container a.product_img_link");

        private By addToCartButton = By.CssSelector("button[name='Submit']");

        public void AddToCart()
        {
            Click(addToCartButton);
        }

        public void ViewProductDetails()
        {
            Click(_productDetailsButton);
        }
        public void NavigateToProduct(string productId)
        {
            By productLink = By.CssSelector($"[data-id-product='{productId}']");
            Click(productLink);
        }

        public void ClickAddToCartButton()
        {
            Click(addToCartButton);
        }
    }
}