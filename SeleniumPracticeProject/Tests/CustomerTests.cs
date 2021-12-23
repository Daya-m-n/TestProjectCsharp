using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPracticeProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.Tests
{
    public class CustomerTests
    {
        public IWebDriver driver;
       
        [SetUp]
        public void SetUp() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://phptravels.net/api/admin"); 
        }
        [Test]
        public void AddNewCustomerTest() 
        {
            LoginPage lp= new LoginPage(driver);
            lp.Login();

            DashBoardPage dbp=new DashBoardPage(driver);
            dbp.ClickOnCustomer();

            CustomerManagementPage cmp=new CustomerManagementPage(driver);
            cmp.plusIcon.Click();

            AddCustomerPage acp=new AddCustomerPage(driver);
            acp.CreateCustomer();
        }

       /* [Test]
        public void EditCustomerTest() 
        {
        
        }*/
    }
}
