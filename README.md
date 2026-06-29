# Automation Framework

## Overview

This project implements a robust and maintainable Selenium WebDriver automation framework in C# for the Swag Labs e-commerce application. The framework was developed following industry best practices, including the Page Object Model (POM), data-driven testing, reusable utility methods, and automated reporting using Extent Reports.

The objective of this project was to build a scalable automation framework capable of executing functional and regression test scenarios while maintaining clean, modular, and reusable code.

---

## Project Objectives

* Build a maintainable Selenium automation framework using C#
* Implement the Page Object Model (POM) design pattern
* Perform data-driven testing using JSON/XML files
* Generate detailed execution reports using Extent Reports
* Develop reusable utility methods for common actions
* Automate critical user workflows of an e-commerce application

---

## Application Under Test

**Website:** Swag Labs
**URL:** https://www.saucedemo.com/

Swag Labs is a demo e-commerce application used for automation testing and covers common business workflows such as authentication, product management, cart operations, and checkout.

---

## Project Structure

```text
AutomationFramework/
│
├── Pages/
├── Properties/
├── Reports/
├── TestData/
├── TestResults/
├── Tests/
├── Utilities/
├── packages.config
├── SwagLabsAutomation.csproj
├── SwagLabsAutomation.sln
└── README.md
```

---

## Design Pattern

### Page Object Model (POM)

The framework implements the Page Object Model design pattern to:

* Improve code maintainability
* Promote code reusability
* Separate test logic from UI elements
* Reduce duplication across test cases
* Simplify future enhancements

Each web page is represented by a separate class containing page elements and user actions.

---

## Data-Driven Testing

Data-driven testing is implemented using JSON and XML files to execute test scenarios with multiple datasets without modifying test scripts.

Benefits include:

* Increased test coverage
* Reduced hard-coded values
* Improved maintainability
* Easier management of test data

---

## Reporting

The framework integrates Extent Reports to provide detailed execution reports, including:

* Test summary
* Pass and fail status
* Execution logs
* Failure screenshots
* Execution time

Generated reports can be found inside the `Reports` directory.

---

## Reusable Utility Methods

The framework includes generalized utility methods for common operations, including:

* Login and logout operations
* Navigation methods
* Explicit wait conditions
* Screenshot capturing
* Alert handling
* Configuration management
* Report generation

These utilities reduce code duplication and improve framework maintainability.

---

## Automated Test Coverage

The framework contains more than 20 automated test scenarios covering the following modules:

### Login Tests

* Valid login
* Invalid login
* Locked user login
* Empty credentials validation

### Product Tests

* Product listing verification
* Product sorting
* Product information validation

### Cart Tests

* Add products to cart
* Remove products from cart
* Cart item verification

### Checkout Tests

* Customer information submission
* Checkout workflow validation
* Order completion
* Order confirmation

### Logout Tests

* User logout
* Session termination validation

---

## Technologies Used

* C#
* Selenium WebDriver
* NUnit
* JSON/XML
* Extent Reports
* Visual Studio
* .NET Framework

---

## Setup and Execution

### Prerequisites

* Visual Studio
* .NET Framework
* Google Chrome
* ChromeDriver
* NuGet Package Manager

### Installation

Clone the repository:

```bash
git clone https://github.com/MariaAsad9/Automation-Framework.git
```

Open the solution:

SwagLabsAutomation.sln

Restore NuGet packages and build the project.

Execute the tests using NUnit Test Explorer.

---

## Project Deliverables

This project includes:

* Complete source code
* Page Object Model implementation
* Data-driven testing
* Extent Reports
* Reusable utility methods
* Test data files
* Documentation and README
* Generated test reports

---

## Author

**Maria Asad**
