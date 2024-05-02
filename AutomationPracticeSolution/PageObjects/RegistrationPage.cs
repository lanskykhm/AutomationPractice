using AutomationPracticeSolution.Helper;
using OpenQA.Selenium;

namespace AutomationPracticeSolution.PageObjects
{
    public class RegistrationPage : BasePage
    {
        private By emailInput = By.Id("email_create");
        private By createAccountButton = By.Id("SubmitCreate");
        private By genderMrRadioButton = By.Id("id_gender1");
        private By genderMrsRadioButton = By.Id("id_gender2");
        private By firstNameInput = By.Id("customer_firstname");
        private By lastNameInput = By.Id("customer_lastname");
        private By passwordInput = By.Id("passwd");
        public By daysDropdown = By.Id("days");
        public By monthsDropdown = By.Id("months");
        public By yearsDropdown = By.Id("years");
        public By registrationForm = By.Id("account-creation_form");

        public RegistrationPage() : base()
        {
        }

        public void EnterEmail(string email)
        {
            EnterText(emailInput, email);
        }

        public void ClickCreateAccount()
        {
            Click(createAccountButton);
        }

        public void SelectGender(string gender)
        {
            if (gender.ToLower() == "mr")
            {
                Click(genderMrRadioButton);
            }
            else if (gender.ToLower() == "mrs")
            {
                Click(genderMrsRadioButton);
            }
        }

        public void EnterFirstName(string firstName)
        {
            EnterText(firstNameInput, firstName);
        }

        public void EnterLastName(string lastName)
        {
            EnterText(lastNameInput, lastName);
        }

        public void EnterPassword(string password)
        {
            EnterText(passwordInput, password);
        }

        public bool IsRegisteredSuccessfully()
        {
            return IsElementDisplayed(registrationForm);
        }
        public void ScrollToDatePicker()
        {
            IWebElement datePicker = Driver.FindElement(yearsDropdown);

            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", datePicker);
        }
        public void SelectDateOfBirth(string day, string month, string year)
        {
            Click(daysDropdown);
            SelectElement(daysDropdown, day);

            Click(monthsDropdown);
            SelectElement(monthsDropdown, month);

            Click(yearsDropdown);
            SelectElement(yearsDropdown, year);
        }
    }

}
