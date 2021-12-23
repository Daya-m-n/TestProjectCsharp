
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.PageObjects
{
    public class LoginPage
    {
        public IWebDriver driver;

        //public TestContext TestContext { get; set; }
        public LoginPage(IWebDriver driver) 
        { 
          this.driver = driver;
        }

        public IWebElement emailTextField => driver.FindElement(By.Name("email"));
        public IWebElement passwordTextField => driver.FindElement(By.Name("password"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public void Login() 
        {
            emailTextField.SendKeys("admin@phptravels.com");
            passwordTextField.SendKeys("demoadmin");
            loginButton.Click();
        }

        public void InvalidLogin()
        {
            emailTextField.SendKeys("admin@phptravels.com");
            passwordTextField.SendKeys("demoadmin2");
            loginButton.Click();
        }
    }  
}
