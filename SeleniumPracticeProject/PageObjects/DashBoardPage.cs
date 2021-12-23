using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.PageObjects
{
    public class DashBoardPage
    {
        public IWebDriver driver;
        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement accounts => driver.FindElement(By.XPath("//a[contains(text(),'Accounts')]"));
        public IWebElement customers => driver.FindElement(By.XPath("//a[text()='Customers']"));
        public IWebElement logoutButton => driver.FindElement(By.XPath("//strong[contains(text(),'Logout')]"));

        public void ClickOnCustomer() 
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(accounts).Perform();
            customers.Click();
        }
        
    }
}
