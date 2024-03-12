using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Utilities;

namespace SpecFlowProject2024.Pages
{
    public class Homepage(WebDriver driver)
    {
        public Homepage()
        {

        }

        public void navigateToTMPage(IWebDriver driver)
        {
            try
            {
                // navigate to time n material module (click on administration dropdown link)
                IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
                administrationDropdown.Click();


                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible)(By.XPath("//*[contains(text(),'Time & Materials"));


                waitUtils.waitToBeVisible(driver, "Xpath", "//*[contains(text(),'Time & Materials", 3);
                IWebElement timeAndmaterialOption = driver.FindElement(By.XPath("//*[contains(text(),'Time & Materials)]"));
                timeAndmaterialOption.Click();
            }
            catch (Exception ex)
            {
            Assert.Fail("turnup portal dashboard is not clickable");
            }
        }
        public void NavigateToEmployeePage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time and Material module (Click on the Administration Dropdown Menu link)
                IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
                administrationDropdown.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

                waitUtils.WaitToBeVisible(driver, "XPath", "//div[3]/div/div/ul/li[5]/ul/li[2]/a", 3);

                IWebElement employeeOption = driver.FindElement(By.XPath("//div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal dashboard panel is not clickable");
            }
        }
        public void verifyLoggedInUser(IWebDriver driver)
        {
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/ul/li[2]/a"));
            if (hellohari.Text == "hello hari")
            {
                Console.WriteLine("user has logged in succesfully");
            }
            else
            {
                Console.WriteLine("user has not been logged in successfully");

            }
        }

        internal void verifyLoggedInUser(Func<IWebDriver> driver)
        {
            throw new NotImplementedException();
        }
    }
}

    
