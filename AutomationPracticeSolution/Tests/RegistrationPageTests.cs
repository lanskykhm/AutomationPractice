using AutomationPracticeSolution.Helper;
using NUnit.Framework;
using System;

namespace AutomationPracticeSolution.Tests
{
    public class RegistrationPageTests : BasePage
    {
        [Test]
        public void TestSuccessfulRegistration()
        {
            // Arrange
            var registrationPage = new PageObjects.RegistrationPage();

            // Act
            registrationPage.NavigateToUrl("http://www.automationpractice.pl/index.php?controller=authentication&back=my-account#account-creation");
            registrationPage.EnterEmail("lanskix.mariya@gmail.com");
            registrationPage.ClickCreateAccount();
            registrationPage.SelectGender("Mrs");
            registrationPage.EnterFirstName("Mariia");
            registrationPage.EnterLastName("Lanskykh");
            registrationPage.EnterPassword("password123");
            registrationPage.SelectDateOfBirth("29", "January", "1992");
            Assert.That(registrationPage.IsRegisteredSuccessfully(), "Registration was not successful.");
        }

        [Test]
        public void TestInvalidEmail()
        {
            var registrationPage = new PageObjects.RegistrationPage();
            registrationPage.NavigateToUrl("http://www.automationpractice.pl/index.php?controller=authentication&back=my-account#account-creation");
            registrationPage.EnterEmail("invalid_email");
            registrationPage.ClickCreateAccount();

        }

        [Test]
        public void TestWeakPassword()
        {
            var registrationPage = new PageObjects.RegistrationPage();
            registrationPage.NavigateToUrl("http://www.automationpractice.pl/index.php?controller=authentication&back=my-account#account-creation");
            registrationPage.EnterEmail("test456@gmail.com");
            registrationPage.ClickCreateAccount();
            registrationPage.EnterPassword("weak");
            Assert.That(registrationPage.IsElementDisplayed(registrationPage.errorMessageBox), "Error message box should be displayed for weak password.");
        }
    }
}

