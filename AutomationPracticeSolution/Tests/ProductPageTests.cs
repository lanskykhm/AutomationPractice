using AutomationPracticeSolution.Helper;
using AutomationPracticeSolution.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class ProductPageTests : BasePage
    {
        private ProductPage _productPage = new ProductPage();

        [SetUp]
        public void Setup()
        {
            _productPage = new ProductPage();
            Driver.Navigate().GoToUrl("http://www.automationpractice.pl/product");
        }

        [Test]
        public void TestAddToCart()
        {
            try
            {
                _productPage.AddToCart();
                Console.WriteLine("Product added to cart successfully.");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Add to cart button not found.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"An error occurred: {ex.Message}");
            }
        }

        [Test]
        public void TestViewProductDetails()
        {
            try
            {
                _productPage.ViewProductDetails();
                Console.WriteLine("Product details viewed successfully.");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Product details not found.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"An error occurred: {ex.Message}");
            }
        }
    }
}
