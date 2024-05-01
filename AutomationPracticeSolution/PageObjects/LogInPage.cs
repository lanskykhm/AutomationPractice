using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

public class LoginPage : BasePage
{
    private By emailInput = By.Id("email");
    private By passwordInput = By.Id("passwd");
    private By signInButton = By.Id("SubmitLogin");

    public void EnterEmail(string email)
    {
        Driver.FindElement(emailInput).SendKeys(email);
    }

    public void EnterPassword(string password)
    {
        Driver.FindElement(passwordInput).SendKeys(password);
    }

    public void ClickSignIn()
    {
        Driver.FindElement(signInButton).Click();
    }
}
