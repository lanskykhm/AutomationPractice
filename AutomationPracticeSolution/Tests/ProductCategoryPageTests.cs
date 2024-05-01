using AutomationPracticeSolution.Helper;
using AutomationPracticeSolution.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class ProductCategoryPageTests : BasePage
    {
        private ProductCategoryPage _productCategoryPage = new ProductCategoryPage();
        private SearchResultPage _searchResultsPage = new SearchResultPage();
        [SetUp]
        public void Setup()
        {
            _productCategoryPage = new ProductCategoryPage();
            _searchResultsPage = new SearchResultPage();
            Driver.Navigate().GoToUrl("http://www.automationpractice.pl/");
        }

        [Test]
        public void TestClickProductLink()
        {
            _searchResultsPage.Search("dress");
            _productCategoryPage.ClickProductLink();

            Assert.That(Driver.Url, Is.EqualTo("http://www.automationpractice.pl/product"), "Product link was not clicked successfully.");
            Console.WriteLine("Product link clicked successfully.");
        }
    }
}
