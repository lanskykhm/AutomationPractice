using AutomationPracticeSolution.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class LoginPageTests : BasePage
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            try
            {
                LoginPage loginPage = new LoginPage();
                loginPage.NavigateToUrl("http://www.automationpractice.pl/");
                loginPage.ClickSignIn();

                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
                loginPage.EnterEmail("validemail@example.com");

                IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("passwd")));
                loginPage.EnterPassword("password");

                IWebElement signInButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("SubmitLogin")));
                loginPage.ClickSignIn();


                Console.WriteLine("LoginWithValidCredentials test passed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"LoginWithValidCredentials test failed: {ex.Message}");
                throw;
            }
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            try
            {
                LoginPage loginPage = new LoginPage();
                loginPage.NavigateToUrl("http://www.automationpractice.pl/");
                loginPage.ClickSignIn();

                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
                loginPage.EnterEmail("invalidemail@example.com");

                IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("passwd")));
                loginPage.EnterPassword("invalidpassword");

                IWebElement signInButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("SubmitLogin")));
                loginPage.ClickSignIn();

                Console.WriteLine("LoginWithInvalidCredentials test passed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"LoginWithInvalidCredentials test failed: {ex.Message}");
                throw;
            }
        }
    }
}
