using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeProject.CustomMethods
{
    public static class BaseClass
    {
        /// <summary>
        /// This method is used to click on a webelement.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="ele"></param>
        public static void ClickOnElement(IWebDriver driver, IWebElement ele)
        {
            ele.Click();
        }

        /// <summary>
        /// This a custom method to enter a text into a textfield.
        /// </summary>
        /// <param name="ele"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement ele, string value)
        {
            ele.Click();
            ele.Clear();
            ele.SendKeys(value);
        }

        /// <summary>
        /// This is a custom method to select a element by using visible text
        /// </summary>
        /// <param name="ele"></param>
        /// <param name="visibleText"></param>
        public static void Select(IWebElement ele,string visibleText)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByText(visibleText);
        }

        /// <summary>
        /// This is a custom method to select a element by using index.
        /// </summary>
        /// <param name="ele"></param>
        /// <param name="visibleText"></param>
        public static void Select(IWebElement ele, int index)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByIndex(index);
        }
    }
}
