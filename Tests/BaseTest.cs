﻿using SwagLabUITestProject.Helpers;
using SwagLabUITestProject.Pages;
using SwagLabUITestProject.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Tests
{
    public class BaseTest
    {
        public IWebDriver driver { get; set; }
        public WebDriverWait wait { get; set; }
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            driver = SeleniumHelpers.InitializeWebDriver();
            wait = SeleniumHelpers.SetWebDriverWait(driver, 20);
            driver.Navigate().GoToUrl(TestVariables.initialUrl);
            LoginPage loginPage = new LoginPage(driver, wait);
            loginPage.Login(TestVariables.standartUser, TestVariables.password);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                // TODO can get a screenshot
            }
            driver.Quit();
        }
    }
}
