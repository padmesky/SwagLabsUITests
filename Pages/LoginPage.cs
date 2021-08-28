using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages
{
    public class LoginPage
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

        private By userNameFieldLocator = By.Id("user-name");
        private By passwordFieldLocator = By.Id("password");
        private By loginBtnLocator = By.Id("login-button");

        private void EnterUserName(string username)
        {
            IWebElement userNameField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(userNameFieldLocator));
            userNameField.SendKeys(username);
        }

        private void EnterPassword(string password)
        {
            IWebElement passwordField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(passwordFieldLocator));
            passwordField.SendKeys(password);
        }

        private void ClickLogin()
        {
            IWebElement loginBtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(loginBtnLocator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(loginBtn));
            loginBtn.Click();
        }

        public void Login(string username, string password)
        {
            this.EnterUserName(username);
            this.EnterPassword(password);
            this.ClickLogin();
            // TODO: Check if login is successful or is there any error message!
        }
    }
}
