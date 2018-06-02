using EcommerceProject.Utilities;
using OpenQA.Selenium;


namespace EcommerceProject.PageObjects
{
   public class LoginPageObjects :Driver

    {

        static By EmailAddress = By.Id("email");
        static By Password = By.Id("passwd");
        static By SubmitButton = By.Name("SubmitLogin");

        public static void EnterEmailAddress(string email)
        {
            driver.FindElement(EmailAddress).SendKeys(email);
        }

        public static void EnterPassword(string password)
        {
            driver.FindElement(Password).SendKeys(password);
        }
        public static void ClickSubmitButton()
        {
            driver.FindElement(SubmitButton).Click();
        }

        public static void Login(string userName, string password)
        {
          HomePageObjects.ClickSignInButton();
          EnterEmailAddress(userName);
          EnterPassword(password);
          ClickSubmitButton();
        }
    }
}



 