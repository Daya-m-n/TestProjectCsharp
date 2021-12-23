using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.PageObjects
{
    public class CustomerManagementPage
    {
        IWebDriver driver;
        public CustomerManagementPage(IWebDriver driver)
        {
            this.driver= driver;
        }

        public IWebElement plusIcon => driver.FindElement(By.XPath("//button[contains(text(),'Add')]"));

    }
}
