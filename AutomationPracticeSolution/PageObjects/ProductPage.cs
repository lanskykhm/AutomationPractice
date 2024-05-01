using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class ProductPage : BasePage
    {
        private readonly By _addToCartButton = By.CssSelector("#add_to_cart button");
         private readonly By _productDetailsButton = By.CssSelector(".btn-default");
        public ProductPage() : base()
        {
        }

        public void AddToCart()
        {
            Click(_addToCartButton);
        }
        public void ViewProductDetails()
        {
            Click(_productDetailsButton);
        }
    }
}
