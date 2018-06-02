using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EcommerceProject.Utilities;
using EcommerceProject.PageObjects;

namespace EcommerceProject
{
    [TestClass]
    public class Testcases


    {
        Driver drivobj = new Driver();

        [TestInitialize]

        public void OpenBrowser()

        {
            Driver.driver = drivobj.OpenBrowser("Chrome", "http://automationpractice.com/index.php");
        }



        [TestMethod]
        public void InvalidLogin()
        {
            LoginPageObjects.Login("funisnowman@gmail.com", "tester");
            MyAccountPageObjects.VerifyErrorTextDisplay();
        }


        [TestMethod]
        public void ValidLogin()
        {

            LoginPageObjects.Login("funisnowman@gmail.com", "blessed");
            MyAccountPageObjects.VerifyMyAccountTextDisplay();

        }


        [TestCleanup]
        public void CloseBrowser()
        {
            Driver.driver.Close();
        }
    }
}
