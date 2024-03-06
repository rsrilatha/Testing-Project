using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Utilities;

namespace Testing_Project.Pages
{
    public class TimeMaterialpage
    {
        public void createTimeMaterialRecord(IWebDriver driver)
        {
            //create a new time record

            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            //Click on typecode
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typeCodeMainDropdown.Click();
            Thread.Sleep(2000);

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]\r\n"));
            typeCodeDropdown.Click();
            //click on code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Test");
            //enter the description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("T ");
            //enter the price
            waitUtils.waitToBeClickable(driver, "Xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 1);
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("25");
            //click on the save button
            waitUtils.waitToBeVisible(driver, "Savebutton", 2);
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            Thread.Sleep(2000);
            //check if a new time record has been created successfully
            waitUtils.waitToBeVisible(driver,"Xpath","//*[contains(text(),'Time & Materials",3);
            IWebElement goTolastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goTolastpageButton.Click();
            IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            /*if (newRecordCode.Text == "Test")
            {
                Console.WriteLine("new material/time record has been created successfully");
            }
            else
            {
                Console.WriteLine("new material/time record has not been created");

            }*/
            Assert.That(newRecordCode.Text ==  "Test"); //new maerial/time has not been created
        }
        public void editTimeMaterialRecord(IWebDriver driver)
        {
            //Edit a new time record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codebox = driver.FindElement(By.Id("Code"));
            codebox.SendKeys("t s");
            IWebElement DescriptionBox = driver.FindElement(By.Id("Description"));
            DescriptionBox.SendKeys("T s");
            IWebElement PriceBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceBox.SendKeys("$2.00");
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            SaveButton.Click();
            Thread.Sleep(2000);
            //check if the new time record has been edited successfully
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastpageButton.Click();
        }
        public void deleteTimeMaterialRecord(IWebDriver driver)
            {

            }

        internal void deleteTimeMaterialRecord(Func<IWebDriver> driver)
        {
            throw new NotImplementedException();
        }
    }
    }

    

