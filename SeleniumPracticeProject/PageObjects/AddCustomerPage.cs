using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.PageObjects
{
    public class AddCustomerPage
    {
        IWebDriver driver;
        public AddCustomerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement firstNameTxtField => driver.FindElement(By.Name("fname"));
        public IWebElement lastNameTxtField => driver.FindElement(By.Name("lname"));
        public IWebElement emailTxtField => driver.FindElement(By.Name("email"));
        public IWebElement passwordTxtField => driver.FindElement(By.Name("password"));
        public IWebElement mobNoTxtField => driver.FindElement(By.Name("mobile"));
        public IWebElement countryDropDown => driver.FindElement(By.XPath("//span[@class='select2-arrow']"));
        public IWebElement selectCountry => driver.FindElement(By.XPath("//div[text()='India']"));
        public IWebElement adress1TextField => driver.FindElement(By.Name("address1"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//button[text()='Submit']"));

        public void CreateCustomer()
        {
            firstNameTxtField.SendKeys("abs");
            lastNameTxtField.SendKeys("ccc");
            emailTxtField.SendKeys("imvk18@gmail.com");
            passwordTxtField.SendKeys("ghggvvv");
            mobNoTxtField.SendKeys("8877665544");
            countryDropDown.Click();
            selectCountry.Click();
            adress1TextField.SendKeys("Bengaluru");
            submitButton.Click();
        }

    }
}
