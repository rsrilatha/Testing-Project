﻿using OpenQA.Selenium;

namespace Testing_Project.Pages
{
    public class Loginpage
    {
        private readonly By usernameTextboxLocator = By.Id("username");
        IWebElement usernameTextbox;
        private readonly By passwordTextboxLocator = By.Id("password");
        IWebElement passwordTextbox;
        private readonly By loginButtonLocator = (By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        IWebElement loginButton;
        public void LoginActions(IWebDriver driver, string username, string password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //launch turnup portal and navigate to website login page
            String baseURL = "http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f";
            driver.Navigate().GoToUrl(baseURL);
            //identify username textbox and enter the valid username 
            usernameTextbox = driver.FindElement(usernameTextboxLocator);
            usernameTextbox.SendKeys("username");
            //Identify password textbox and enter password
            passwordTextbox = driver.FindElement(passwordTextboxLocator);
            passwordTextbox.SendKeys("password");
            ////Just to wait for 5 seconds doing nothing
            Thread.Sleep(1000);
            ////Identify login button and click on Login Button
            loginButton = driver.FindElement(loginButtonLocator);
            loginButton.Click(); 
        }
          
    }
}
