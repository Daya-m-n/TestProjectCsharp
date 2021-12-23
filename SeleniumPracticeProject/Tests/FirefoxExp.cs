using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject
{
    public class FirefoxExp
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("q")).SendKeys("Tesla");
            System.Threading.Thread.Sleep(1500);
            driver.FindElement(By.Name("q")).Clear();
            System.Threading.Thread.Sleep(1500);
            driver.FindElement(By.Name("q")).SendKeys("Tata");
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void Test2()
        {
            driver.FindElement(By.Name("q")).SendKeys("Tesla model 3");
            System.Threading.Thread.Sleep(1500);
            driver.FindElement(By.Name("q")).Clear();
            System.Threading.Thread.Sleep(1500);
            driver.FindElement(By.Name("q")).SendKeys("Tata nexon EV");
            System.Threading.Thread.Sleep(1500);
        }

        [TearDown]
        public void Close()
        {
            driver.Close();

        }
    }
}
