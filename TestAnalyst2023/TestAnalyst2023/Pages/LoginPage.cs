using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyst2023.Pages
{ 
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // Open Chrome browser and maximize
            // If Selenium Chrome driver was not installed. You have to download and add the file path manually inside ChromeDriver()

            
            driver.Manage().Window.Maximize();

            // Launch Turnup Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Identify username box and enter a valid username
            IWebElement userBox = driver.FindElement(By.Id("UserName"));
            userBox.SendKeys("hari");

            // Identify the password box and enter a valid password
            IWebElement passwordBox = driver.FindElement(By.Id("Password"));
            passwordBox.SendKeys("123123");

            // Click remember me checkbox
            IWebElement rememberBox = driver.FindElement(By.Id("RememberMe"));
            rememberBox.Click();

            // Click log in button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();


        }

    }
}
