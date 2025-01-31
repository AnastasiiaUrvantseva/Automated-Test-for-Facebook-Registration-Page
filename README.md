# Automated Test for Facebook Registration Page

## Overview
This project contains an automated test script designed to simulate the user registration process on the Facebook sign-up page. The test is implemented using Selenium, C#, and NUnit to ensure the registration page functions correctly under various input scenarios.

## Key Features
- User Registration Simulation:
  - Automates the process of clicking the "Create New Account" button.
  - Fills in the registration form with name, email, password, date of birth, and gender.
  - Submits the registration form.
  
- Validation of Error Messages:
  - Verifies that appropriate error messages are shown when invalid or fake account data is entered.

## Technologies Used:
- **Selenium** (for browser automation)
- **C#** (for writing the test script)
- **NUnit** (for running and asserting the test cases)

## Installation Steps
- Clone the repository
- Install required dependencies (Open the solution file in Visual Studio and use NuGet Package Manager to install Selenium WebDriver and NUnit.)
- Configure WebDriver:
Download ChromeDriver (or the appropriate WebDriver for your browser) and set it in your system’s PATH.
- Run the Test:
In Visual Studio, build and run the test using NUnit. The test will launch the browser, simulate the registration process, and validate error messages for fake inputs.

## How It Works
- The test script begins by opening the Facebook sign-up page.⬇️
- It simulates user actions like clicking the "Create New Account" button and filling in the registration form.⬇️
- After form submission, the script checks for error messages when fake or invalid data is entered.⬇️
- The test results are displayed, showing whether the page behaves as expected.
