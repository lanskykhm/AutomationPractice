using AutomationPracticeSolution.Helper;
using AutomationPracticeSolution.PageObjects;
using NUnit.Framework;
using System;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class SearchResultPageTests : BasePage
    {
        [Test]
        public void TestSearch()
        {
            try
            {
                SearchResultPage searchResult = new SearchResultPage();
                searchResult.Search("dress");

                SearchResultPage searchResultPage = new SearchResultPage();
                string resultHeading = searchResultPage.GetResultHeadingText();

                Console.WriteLine($"Search result heading: {resultHeading}");

                Assert.That(resultHeading.Contains("dress"), "Search result does not contain expected keyword");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Assert.Fail();
            }
        }

        [Test]
        public void TestMultipleSearch()
        {
            try
            {
                SearchResultPage searchResult = new SearchResultPage();
                searchResult.Search("t-short");

                SearchResultPage searchResultPage = new SearchResultPage();
                searchResultPage.AddFirstItemToCart();

                Console.WriteLine("Multiple items added to cart successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Assert.Fail();
            }
        }
    }
}
