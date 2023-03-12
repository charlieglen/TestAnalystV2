using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAnalyst2023.Pages;
using TestAnalyst2023.Utilities;

namespace TestAnalyst2023.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employees_Tests : CommonDriver
    {
      
            // Page object initialization andd definition
            HomePage homePageObj = new HomePage();
            EmployeesPage employeePageObj = new EmployeesPage();

        
        [Test, Order(1)]
        public void CreateEmployeesTest()
        {
            Thread.Sleep(2000);
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.CreateEmployees(driver);
        }
        [Test, Order(2)]
        public void EditEmployeesTest()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.EditEmployees(driver);

        }
        [Test, Order(3)]
        public void DeleteEmployeesTest()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.DeleteEmployees(driver);
        }
        
    }
}


