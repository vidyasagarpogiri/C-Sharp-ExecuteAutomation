﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SeleniumFirst
{
    class EAPageObject
    {


        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesToChromeDriver.chrome, this);
        }


        [FindsBy(How = How.Id, Using ="TitleId")]
        public IWebElement ddTitleID { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string firstName, string middleName)        // moze byc void bo nie zwraca nam potem zadnego obiektu
        {

            ddTitleID.SelectDropDown("Mr.");
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            
            
            
            
            //SeleniumSetMethods.SelectDropDown(ddTitleID, "Mr.");
            //SeleniumSetMethods.EnterText(txtInitial, initial);
            //SeleniumSetMethods.EnterText(txtFirstName, firstName);
            //SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            //SeleniumSetMethods.Click(btnSave);
        }
    }
}
