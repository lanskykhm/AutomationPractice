using AutomationPracticeSolution.Helper;
using AutomationPracticeSolution.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class HomePageTests : BasePage
    {
        private HomePage _homePage = new HomePage();

        [SetUp]
        public void Setup()
        {
            _homePage = new HomePage();
            Driver.Navigate().GoToUrl("http://www.automationpractice.pl/");
        }

        [Test]
        public void TestSignInButton()
        {
            _homePage.ClickLogIn();
            Console.WriteLine("Sign-in button clicked successfully.");
        }

         public void VerifySignInButton()
    {
        try
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToUrl("http://www.automationpractice.pl/");
            homePage.ClickLogIn();
            Console.WriteLine("SignInButton test passed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"SignInButton test failed: {ex.Message}");
            throw;
        }
    }
    }
}
