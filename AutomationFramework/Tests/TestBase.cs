using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SwagLabsAutomation.Utilities;
using System;

namespace SwagLabsAutomation.Tests
{
    [TestClass]
    public class TestBase
    {
        protected IWebDriver driver;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            string testName = TestContext.TestName;
            string status = TestContext.CurrentTestOutcome == UnitTestOutcome.Passed ? "PASS" : "FAIL";

            // Log test result to HTML report
            SimpleReport.Log(testName, status);

            // Quit driver
            driver.Quit();
        }
    }
}
