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
    }
}
