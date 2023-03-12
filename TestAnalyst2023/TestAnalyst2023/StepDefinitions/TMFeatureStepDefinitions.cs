using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;
using TestAnalyst2023.Pages;
using TestAnalyst2023.Utilities;

namespace TestAnalyst2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver   
    {

        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // Login page object initilization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Charlie", "Actual code and expected code do not match.");
            Assert.That(newDescription == "Charlie", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$100.00", "Actual price and expected price do not match.");
        }

        [When(@"I update '([^']*)' on an existing time and material record")]
        //public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
        //{
        //    tmPageObj.EditTM(driver, description);
        //}

        //[Then(@"The record should have the updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveTheUpdated(string description)
        //{

        //}
        [When(@"I update '([^']*)', '([^']*)', '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description, string code, string prices)
        {
            tmPageObj.EditTM(driver, description, code, prices);
        }

        [Then(@"The record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description, string code, string prices)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);
            //convert string to decimal+currency. Not the best practice
            string prices123 = "$" + prices + ".00";

            Assert.That(editedDescription == description, "Actual code and expected code do not match.");
            Assert.That(editedCode == code, "Actual description and expected description do not match.");
            Assert.That(editedPrice == prices123, "Actual price and expected price do not match.");
        }

        [When(@"I deleted the last time and material record created")]
        public void WhenIDeletedTheLastTimeAndMaterialRecordCreated()
        {
            tmPageObj.DeleteTM(driver);
        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {

            string editedCode = tmPageObj.GetEditedCode(driver);
            Assert.That(editedCode != "Charlie", "Delete record failed!");
        }

    }
}
