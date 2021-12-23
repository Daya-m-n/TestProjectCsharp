using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumPracticeProject.CustomMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.Tests
{
    public class LoginExp
    {
        [Test]
        public void login() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://phptravels.net/api/admin");
            driver.FindElement(By.Name("email")).SendKeys("admin@phptravels.com");
            driver.FindElement(By.Name("password")).SendKeys("demoadmin");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[contains(text(),'Accounts ')]"))).Perform();
            driver.FindElement(By.XPath("//a[text()='Customers']")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'Add')]")).Click();

            driver.FindElement(By.Name("fname")).SendKeys("Virat");
            driver.FindElement(By.Name("lname")).SendKeys("Kohli");
            driver.FindElement(By.Name("email")).SendKeys("kohlivk@oneeight.in");
            driver.FindElement(By.Name("password")).SendKeys("viratkohlivk");
            driver.FindElement(By.Name("mobile")).SendKeys("8899887766");
            driver.FindElement(By.XPath("//span[@class='select2-arrow']")).Click();
            driver.FindElement(By.XPath("//div[text()='India']")).Click();
            driver.FindElement(By.Name("address1")).SendKeys("Bengaluru");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("currency")));
            select.SelectByText("INR");

            driver.FindElement(By.XPath("//button[text()='Submit']")).Click();
            

        }


    }
}
