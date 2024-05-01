# Bug Report for www.automationpractice.pl/index.php

## Description
This bug report contains a list of identified issues found during testing of the www.automationpractice.pl/index.php website.

## Bugs

### Bug 1: Cyrillic Characters in Email Field
- **Description:** When entering Cyrillic characters (e.g., "кириллица") in the email field during registration, the website accepts the input without displaying any error message.
- **Expected Behavior:** The website should validate the email field and display an error message indicating that Cyrillic characters are not allowed.
- **Steps to Reproduce:**
  1. Navigate to the registration page.
  2. Enter Cyrillic characters in the email field.
  3. Submit the form.
- **Actual Result:** The form is submitted successfully without any validation error.

### Bug 2: Invalid Domain in Email Field
- **Description:** When entering an email address with an invalid domain (e.g., "test@example.invalid") in the email field during registration, the website accepts the input without displaying any error message.
- **Expected Behavior:** The website should validate the email field and display an error message indicating that the domain is invalid.
- **Steps to Reproduce:**
  1. Navigate to the registration page.
  2. Enter an email address with an invalid domain in the email field.
  3. Submit the form.
- **Actual Result:** The form is submitted successfully without any validation error.

### Bug 3: Special Characters in Email Field
- **Description:** When entering an email address with special characters (e.g., "test!@example.com") in the email field during registration, the website accepts the input without displaying any error message.
- **Expected Behavior:** The website should validate the email field and display an error message indicating that special characters are not allowed.
- **Steps to Reproduce:**
  1. Navigate to the registration page.
  2. Enter an email address with special characters in the email field.
  3. Submit the form.
- **Actual Result:** The form is submitted successfully without any validation error.

### Bug 4: Missing Error Message for Empty Email Field
- **Description:** When leaving the email field empty during registration, the website does not display any error message prompting the user to fill in the required field.
- **Expected Behavior:** The website should validate the email field and display an error message indicating that it is required.
- **Steps to Reproduce:**
  1. Navigate to the registration page.
  2. Leave the email field empty.
  3. Submit the form.
- **Actual Result:** The form is submitted successfully without any validation error message.

### Bug 5: Incorrect Email Format Validation
- **Description:** The website does not properly validate email addresses with incorrect format (e.g., missing "@" symbol) during registration.
- **Expected Behavior:** The website should validate the email field and display an error message indicating that the email format is incorrect.
- **Steps to Reproduce:**
  1. Navigate to the registration page.
  2. Enter an email address with incorrect format.
  3. Submit the form.
- **Actual Result:** The form is submitted successfully without any validation error message.

## Additional Information
Please note that these bugs were identified during testing and may impact the user experience on the website. It is recommended to fix these issues to ensure proper functionality and data validation.

## Environment
- Browser: Chrome
- Browser Version: 124.0.6367.93
- Operating System: Windows 10