using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAnalyst2023.Utilities;

namespace TestAnalyst2023.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            /* Implicit Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // To use an Explicit Wait we addd below condition
            // must download nuget package for explicit wait - dotnetseleniumextras.waithelpers 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")));
            */


            // Navigate to time and material page
            IWebElement administrationDropdodwn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdodwn.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

        public void GoToEmployeesPage(IWebDriver driver)
        {

            IWebElement administrationDropdodwn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdodwn.Click();

            IWebElement EmployeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeesOption.Click();
        }
    }
}
