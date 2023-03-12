using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAnalyst2023.Utilities;

namespace TestAnalyst2023.Pages
{
    public class EmployeesPage : CommonDriver
    {
        public void CreateEmployees(IWebDriver driver)

        {

            Thread.Sleep(1000);
            IWebElement createNewEmployee = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewEmployee.Click();

            IWebElement employeeName = driver.FindElement(By.Id("Name"));
            employeeName.SendKeys("Charlie");

            IWebElement employeeUsername = driver.FindElement(By.Id("Username"));
            employeeUsername.SendKeys("Charlie");

            IWebElement employeeContact = driver.FindElement(By.Id("ContactDisplay"));
            employeeContact.SendKeys("123134");

            IWebElement employeePassword = driver.FindElement(By.Id("Password"));
            employeePassword.SendKeys("P@ss1234567");

            IWebElement employeeConfirmPassword = driver.FindElement(By.Id("RetypePassword"));
            employeeConfirmPassword.SendKeys("P@ss1234567");

            IWebElement isAdminCheckbox = driver.FindElement(By.Id("IsAdmin"));
            isAdminCheckbox.Click();

            IWebElement employeeVehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            employeeVehicle.SendKeys("12356");

            IWebElement employeeGroup = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div"));
            employeeGroup.Click();

            Thread.Sleep(1000);
            IWebElement employeeGroupSelect = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[2]"));
            employeeGroupSelect.Click();


            IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();


            Thread.Sleep(1000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newEmployee.Text == "Charlie", "Actual code and expected code does not match!");


        }
        public void EditEmployees(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newEmployee.Text == "Charlie")
            {
                IWebElement editEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editEmployee.Click();
            }
            else
            {
                Assert.Fail();
            }

            IWebElement employeeName = driver.FindElement(By.Id("Name"));
            employeeName.Clear();
            employeeName.SendKeys("CharlieNew");

            IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();

            Thread.Sleep(3000);
            IWebElement goToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage1.Click();

            IWebElement editedEmployeeName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(editedEmployeeName.Text == "CharlieNew", "Actual code and expected code does not match!");


        }
        public void DeleteEmployees(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            Thread.Sleep(2000);
            IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            if (newEmployee.Text == "CharlieNew")
            {
                IWebElement deleteEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteEmployee.Click();
            }
            else
            {
                Assert.Fail();
            }

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            Thread.Sleep(1000);
            IWebElement goToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage1.Click();

            IWebElement newEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newEmployeeRecord.Text != "CharlieNew", "Record deletion failed.");

        }
    }
}
