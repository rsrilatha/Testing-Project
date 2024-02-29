using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver ();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
Thread.Sleep(1000);
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/ul/li[2]/a"));
if (hellohari.Text == "hello hari")
{
    Console.WriteLine("user has logged in succesfully");
        }
else
{
    Console.WriteLine("user not logged in successfully");

}

//create a new time record
// navigate to time n material module (click on administration dropdown link)
IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
administrationDropdown.Click();
IWebElement timeAndmaterialoption = driver.FindElement(By.XPath("//*[contains(text(),'Time & Materials')]"));
timeAndmaterialoption.Click();
//click on create new button
IWebElement createNewButton= driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
//Click on typecode
IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
typeCodeMainDropdown.Click();
Thread.Sleep(2000);

IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]\r\n"));
typeCodeDropdown.Click();
//click on code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Testing");
//enter the description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("T description");
//enter the price
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("25");
//click on the save button
IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
saveButton.Click();
Thread.Sleep(2000);
//check if a new time record has been created successfully
IWebElement goTolastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goTolastpageButton.Click();
IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (newRecordCode.Text == "Testing")
{
    Console.WriteLine("new material/time record has been created successfully");
}
else
{
    Console.WriteLine("new material/time record has not been created");

}