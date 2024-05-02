using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage() : base()
        {
        }

        private By searchInput = By.Id("search_query_top");
        private By searchButton = By.CssSelector("button[name='submit_search']");
        private By signInLink = By.CssSelector(".header_user_info a.login");

        public void SearchForProduct(string productName)
        {
            EnterText(searchInput, productName);
            Click(searchButton);
        }

        public void ClickLogIn()
        {
            Click(signInLink);
        }
    }
}
