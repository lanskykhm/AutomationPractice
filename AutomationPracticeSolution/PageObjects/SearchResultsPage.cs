using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage() : base()
        {
        }
        private By resultHeading = By.ClassName("heading-counter");
        private By addToCartButton = By.Name("Submit");
        private By searchInput = By.Id("search_query_top");
        private By searchButton = By.Name("submit_search");
        private By signInButton = By.ClassName("login");
        private By proceedToCheckoutButton = By.CssSelector("a[title='Proceed to checkout']");

        public string GetResultHeadingText()
        {
            return Driver.FindElement(resultHeading).Text;
        }

        public void AddFirstItemToCart()
        {
            Click(addToCartButton);
        }

        public void Search(string searchText)
        {
            EnterText(searchInput, searchText);
            Click(searchButton);
        }
        public void ProceedToCheckout()
        {
            Click(proceedToCheckoutButton);
        }
        public void ClickSignIn()
        {
            Click(signInButton);
        }
    }
}
