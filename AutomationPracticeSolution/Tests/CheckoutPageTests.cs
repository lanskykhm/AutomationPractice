using AutomationPracticeSolution.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class CheckoutPageTests : BasePage
    {
        [Test]
        public void CompleteCheckoutProcess()
        {
            try
            {
                CheckoutPage checkoutPage = new CheckoutPage();
                checkoutPage.NavigateToUrl("http://www.automationpractice.pl/checkout");
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("checkout")));
                checkoutPage.EnterShippingDetails("Mariia Lanskykh", "lanskix.mariya@gmail.com", "095 Street", "Kyiv", "12345", "Ukraine");
                checkoutPage.SelectShippingMethod("Standard Delivery");
                checkoutPage.AcceptTermsAndConditions();
                checkoutPage.ClickPlaceOrderButton();
                wait.Until(ExpectedConditions.UrlContains("order-success"));
                Assert.Equals(Driver.Url.Contains("order-success"), "Order was not successfully placed.");

                Console.WriteLine("CompleteCheckoutProcess test passed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CompleteCheckoutProcess test failed: {ex.Message}");
                throw;
            }
        }
    }
}