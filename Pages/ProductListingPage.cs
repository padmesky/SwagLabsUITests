using SwagLabUITestProject.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages
{
    public class ProductListingPage
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }
        public HeaderContainer headerContainer { get; set; }
        public ProductInventoryContainer productInventory { get; set; }

        public ProductListingPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
            this.headerContainer = new ProductListingHeaderContainer(driver, wait);
            this.productInventory = new ProductInventoryContainer(driver, wait);
        }
    }
}
