
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.WebAuthn;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Timers;
using System.Globalization;
using TestAnalyst2023.Pages;
using TestAnalyst2023.Utilities;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace TestAnalyst2023.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {

        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test, Order(1)]
        public void CreateTMTest()
        {

            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);

        }

        [Test, Order(2)]
        public void EditTMTest()
        {
            homePageObj.GoToTMPage(driver);
            //tmPageObj.EditTM(driver);

        }
        [Test, Order(3)]
        public void DeleteTMTest()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.DeleteTM(driver);

        }
        
    }
}


























