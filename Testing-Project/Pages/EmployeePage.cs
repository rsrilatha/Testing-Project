using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Utilities;

namespace Testing_Project.Pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Created");
        }

        public void EditEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Edited");
        }

        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Deleted");
        }

    }
}

