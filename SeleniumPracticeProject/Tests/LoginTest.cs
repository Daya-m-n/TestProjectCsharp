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
    public class LoginTest
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
        public void ValidLoginToApp() 
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login();
        }

        [Test]
        public void InValidLoginToApp()
        {
            LoginPage lp = new LoginPage(driver);
            lp.InvalidLogin();
        }

        [Test]
        public void LogoutFromApp() 
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login();

            DashBoardPage dbp = new DashBoardPage(driver);
            dbp.logoutButton.Click();
        }
        [TearDown]
        public void TearDown() 
        {
           // driver.Close();
        }
    }
}
