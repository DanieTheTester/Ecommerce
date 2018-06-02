using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Utilities
{
    public class Driver
    {
        public IWebDriver OpenBrowser(string browserName, string url)
        {
            string dir = Environment.CurrentDirectory;
            switch (browserName)
            {
                case "Firefox":
                    //driver = new FirefoxDriver();
                    //driver.Navigate().GoToUrl(url);
                    //driver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(30));
                    //driver.Manage().Window.Maximize();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(url);
                    driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(60);
                    driver.Manage().Window.Maximize();
                    break;
            }
            return driver;
        }

        public static IWebDriver driver
        {
            get;
            set;
        }
    }
}

