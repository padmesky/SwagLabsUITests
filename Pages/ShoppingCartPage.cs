using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages
{
    public class ShoppingCartPage
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        public ShoppingCartPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

        private By checkOutBtnLocator = By.Id("checkout");

        public void Checkout()
        {
            IWebElement checkoutBtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(checkOutBtnLocator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(checkoutBtn));
            checkoutBtn.Click();
        }
    }
}
