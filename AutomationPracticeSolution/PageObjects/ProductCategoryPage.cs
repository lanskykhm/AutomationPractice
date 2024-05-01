using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class ProductCategoryPage : BasePage
    {
        private readonly By _productLink = By.CssSelector(".product_img_link");

        public ProductCategoryPage() : base()
        {
        }

        public void ClickProductLink()
        {
            Click(_productLink);
        }
    }
}
