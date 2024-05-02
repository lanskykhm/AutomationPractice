using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class HomePage : BasePage
    {
        private By _logInButton = By.CssSelector(".login");

        public HomePage() : base()
        {
        }

        public void ClickLogIn()
        {
            Click(_logInButton);
        }

        internal void ClickSignIn()
        {
            throw new NotImplementedException();
        }
        public void SearchForProduct(string productName)
        {
            EnterText(By.Id("search_query_top"), productName);
            Click(By.CssSelector("button[name='submit_search']"));
        }
    }
}
