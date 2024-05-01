using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPracticeSolution.Helper
{
    public class BasePage
    {
        private static IWebDriver? driverInstance;
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BasePage()
        {
            InitializeDriver();
            Driver = driverInstance ?? throw new NullReferenceException("WebDriver is not initialized.");
            Wait = new WebDriverWait(driverInstance, TimeSpan.FromSeconds(10)) ?? throw new NullReferenceException("WebDriverWait is not initialized.");
        }

        private void InitializeDriver()
        {
            if (driverInstance == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                driverInstance = new ChromeDriver(options);
            }
        }

        public void Dispose()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
                driverInstance = null;
            }
        }

        public void Click(By locator)
        {
            try
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
            }
            catch (WebDriverTimeoutException)
            {
            }
            catch (NoSuchElementException)
            {
            }
        }

        public void EnterText(By locator, string text)
        {
            try
            {
                var element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                element.Clear();
                element.SendKeys(text);
            }
            catch (WebDriverTimeoutException)
            {
            }
            catch (NoSuchElementException)
            {
            }
        }

        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return Driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void SelectFromDropdown(By locator, string value)
        {
            try
            {
                var dropdown = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                var selectElement = new SelectElement(dropdown);
                selectElement.SelectByValue(value);
            }
            catch (WebDriverTimeoutException)
            {
            }
            catch (NoSuchElementException)
            {
            }
        }
        protected void SelectElement(By locator, string text)
        {
            try
            {
                var dropdown = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                var selectElement = new SelectElement(dropdown);
                selectElement.SelectByText(text);
            }
            catch (WebDriverTimeoutException)
            {

            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}
