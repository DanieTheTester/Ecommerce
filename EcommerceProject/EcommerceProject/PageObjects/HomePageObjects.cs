using EcommerceProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.PageObjects
{
    public class HomePageObjects : Driver

    {
        static By signInButton = By.CssSelector("div.header_user_info > a");

        static By contactUsButton = By.CssSelector("#contact-link > a");

        public static void ClickSignInButton()
        {
            driver.FindElement(signInButton).Click();
        }


        public static void ClickContactUsInButton()
        {
            driver.FindElement(contactUsButton).Click();
        }

    }
}



