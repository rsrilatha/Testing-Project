using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Pages;
using Testing_Project.Utilities;

namespace Testing_Project.Tests
{
    [Parallelizable]
    [TestFixture]
    public class EmployeeTests : CommonDriver
    {
        [SetUp]
        public void SetUpTimeAndMaterial()
        {
            //open chrome/firfox browser
            driver = new ChromeDriver();
            Loginpage loginpageObj = new Loginpage();
            loginpageObj.LoginActions(driver, "hari", "123123");
            HomePage homePageObj = new HomePage();
            homePageObj.VerifyLoggedInUser(driver);
            homePageObj.NavigateToTMPage(driver);
        }
        [Test, Order(1), Description("This test create a new Employee record with valid details")]
        public void TestCreateEmployeeRecord()
        {


            TimeMaterialpage timematerialpageObj = new TimeMaterialpage();
            timematerialpageObj.createTimeMaterialRecord(driver);

        }
        [Test, Order(2), Description("This test Edit a Employee record")]
        public void TestEditTimeAndMaterialRecord()
        {

            TimeMaterialpage timematerialpageObj = new TimeMaterialpage();
            timematerialpageObj.editTimeMaterialRecord(driver);
        }
        [Test, Order(3), Description("This test Delete a Employee record")]
        public void TestDeleteTimeAndMaterialRecord()
        {
           
            TimeMaterialpage timematerialpageObj = new TimeMaterialpage();
            timematerialpageObj.deleteTimeMaterialRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }






    }
}
    
