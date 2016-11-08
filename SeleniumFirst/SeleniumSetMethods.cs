using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        // Enter Text, extended method for entering text in the control
        public static void EnterText(this IWebElement element, string value)            //11 część
        {
            element.SendKeys(value);
        }

        // Click into a button, checkbox, option etc

        public static void Click(this IWebElement element)
        {
            element.Click();
        }
        
        // Selectiong a dropdown control

        public static void SelectDropDown(this IWebElement element, string value)
        {

            new SelectElement(element).SelectByText(value);
     
        }
    }
}
