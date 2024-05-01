using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class CheckoutPage : BasePage
{
    private By nameInput = By.Id("name");
    private By emailInput = By.Id("email");
    private By addressInput = By.Id("address");
    private By cityInput = By.Id("city");
    private By zipCodeInput = By.Id("zip");
    private By countryInput = By.Id("country");
    private By shippingMethodDropdown = By.Id("shipping-method");
    private By termsCheckbox = By.Id("terms");
    private By placeOrderButton = By.Id("place-order");

    public void EnterShippingDetails(string name, string email, string address, string city, string zipCode, string country)
    {
        Driver.FindElement(nameInput).SendKeys(name);
        Driver.FindElement(emailInput).SendKeys(email);
        Driver.FindElement(addressInput).SendKeys(address);
        Driver.FindElement(cityInput).SendKeys(city);
        Driver.FindElement(zipCodeInput).SendKeys(zipCode);
        Driver.FindElement(countryInput).SendKeys(country);
    }

    public void SelectShippingMethod(string shippingMethod)
    {
        IWebElement shippingDropdown = Driver.FindElement(shippingMethodDropdown);
        SelectElement selectShipping = new SelectElement(shippingDropdown);
        selectShipping.SelectByText(shippingMethod);
    }

    public void AcceptTermsAndConditions()
    {
        Driver.FindElement(termsCheckbox).Click();
    }

    public void ClickPlaceOrderButton()
    {
        Driver.FindElement(placeOrderButton).Click();
    }
}
