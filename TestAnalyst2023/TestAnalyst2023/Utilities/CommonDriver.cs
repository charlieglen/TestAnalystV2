using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAnalyst2023.Pages;

namespace TestAnalyst2023.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            // All common method/processes from both Test pages must be accumalated here for a cleaner code
            // Open Chrome Browser
            driver = new ChromeDriver();

            // Log in page object initializationa dn definiation
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
           
        }

        [TearDown]
        public void CloseTestRun()
        {
            //driver.Quit();

        }

    }
}
