using EcommerceProject.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.PageObjects
{
    public class MyAccountPageObjects: Driver
    {

        static By MyAccountTitle = By.CssSelector("#center_column > h1");

        public static void VerifyMyAccountTextDisplay()

        {

        Assert.IsTrue(driver.FindElement(MyAccountTitle).Text.Contains("MY ACCOUNT"),"My account page is not loaded successfully");
        }







        static By FailedLogin = By.CssSelector("#center_column > div.alert.alert-danger > p");

        public static void VerifyErrorTextDisplay()

        {

            Assert.IsTrue(driver.FindElement(FailedLogin).Text.Contains("There is 1 error"), "My account page is loaded successfully");
        }
    }
}



