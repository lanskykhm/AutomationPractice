using AutomationPracticeSolution.PageObjects;
using AutomationPracticeSolution.Helper;
using NUnit.Framework;

namespace AutomationPracticeSolution.Tests
{
    [TestFixture]
    public class RegistrationTests : BasePage
    {
        [Test]
        public void TestRegistration()
        {
            string email = EmailGenerator.GenerateRandomEmail();

            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.NavigateToUrl("http://www.automationpractice.pl/index.php?controller=authentication&back=my-account#account-creation");
            registrationPage.EnterEmail(email);
            registrationPage.ClickCreateAccount();

            registrationPage.SelectGender("Mrs");
            registrationPage.EnterFirstName("Mariia");
            registrationPage.EnterLastName("Lanskykh");
            registrationPage.EnterPassword("password123");

            registrationPage.SelectDateOfBirth("28", "February", "1992");

            registrationPage.ClickCreateAccount();
            
            Assert.That(registrationPage.IsRegisteredSuccessfully(), "Registration was not successful.");
        }
    }
}
