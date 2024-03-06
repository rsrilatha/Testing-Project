using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Project.Utilities
{
    public class waitUtils
    {
        public static void waitToBeClickable(WebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));   
            if (locatorType == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            if (locatorType == "Name")
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));

        }

        internal static void waitToBeClickable(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static void waitToBeVisible(IWebDriver driver, string v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal static void waitToBeVisible(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static void WaitToBeVisible(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
    }
