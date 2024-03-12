using OpenQA.Selenium.Chrome;
using Testing_Project.Utilities;
using NUnit.Framework;
using SpecFlowProject2024.Pages;
using Testing_Project.Tests;

namespace SpecFlowProject2024.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TMTests : CommonDriver
    {
        Loginpage loginpageObj = new Loginpage();
        Homepage homepageObj = new Homepage();
        TMTests tmpageObj = new TMTests();

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
       [Test,Order(1), Description("This test create a new time /Material record with valid details")]
        public void TestCreateTimeAndMaterialRecord()
        {
       

            TimeMaterialpage timematerialpageObj = new TimeMaterialpage();
            timematerialpageObj.createTimeMaterialRecord(driver);
            
        }
        [Test,Order(2), Description("This test Edit a new time /Material record")]
        public void TestEditTimeAndMaterialRecord()
        {

            TimeMaterialpage timematerialpageObj = new TimeMaterialpage();
            timematerialpageObj.editTimeMaterialRecord(driver);
        }
        [Test, Order(3), Description("This test Delete a new time /Material record")]
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
