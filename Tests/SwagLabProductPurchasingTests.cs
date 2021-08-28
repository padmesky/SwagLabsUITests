using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabUITestProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Tests
{
    [TestClass]
    public class SwagLabProductPurchasingTests : BaseTest
    {
        [TestMethod]
        public void ProductPurchaseTest()
        {
            ProductListingPage productListingpage = new ProductListingPage(driver, wait);
            productListingpage.productInventory.AddToChart("Sauce Labs Bolt T-Shirt");
            productListingpage.headerContainer.ClickShoppingCartIcon();
            ShoppingCartPage shoppingChart = new ShoppingCartPage(driver, wait);
            shoppingChart.Checkout();
            CheckOutInformationPage checkOutInformationPage = new CheckOutInformationPage(driver, wait);
            checkOutInformationPage.EnterInformation("TestName", "TestLastName", "90807");
            ChecoutOverviewPage overviewPage = new ChecoutOverviewPage(driver, wait);
            overviewPage.Finish();

        }
    }
}
