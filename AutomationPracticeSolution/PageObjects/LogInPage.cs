using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class LoginPage : BasePage
    {
        private By emailInput = By.Id("email");
        private By passwordInput = By.Id("passwd");
        private By signInButton = By.Id("SubmitLogin");
        private By _logInButton = By.CssSelector(".login");

        public void EnterEmail(string email)
        {
            Driver.FindElement(emailInput).SendKeys(email);
        }

        public void EnterCredentials(string email, string password)
        {
            EnterText(emailInput, email);
            EnterText(passwordInput, password);
        }

        public void EnterPassword(string password)
        {
            Driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickSignIn()
        {
            Driver.FindElement(signInButton).Click();
        }
        public void ClickLogIn()
        {
            Driver.FindElement(_logInButton).Click();
        }

    }
}