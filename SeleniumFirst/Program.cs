﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using Excel;
using System.Data;


namespace SeleniumFirst
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {

            PropertiesToChromeDriver.chrome = new ChromeDriver(); // tworzenie inicjalizacji do drivera w kalsie PropertiesToChromeDriver
            
            // Nawigacja do Google
            PropertiesToChromeDriver.chrome.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open URL");

        }

        [Test]
        public void ExecuteTest()
        {

            ExcelLiblary.PopulateInCollection(@"C:\C#\Automatyzacja\ExcellData\DataFromExcel.xlsx"); //referencja do pliku excela
           
           

            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login(ExcelLiblary.ReadData(1, "UserName"), ExcelLiblary.ReadData(1, "Password")); // dane z pliku excela - wiersz - nazwa kolumny
            
            //EAPageObject pageEA = pageLogin.Login("Zuru123", "Password123"); // dane wprowadzene w visualu 

            pageEA.FillUserForm(ExcelLiblary.ReadData(1, "Initial"), ExcelLiblary.ReadData(1, "FirstName"), ExcelLiblary.ReadData(1,"MiddleName")); // dane wprowadzone z excela
         
            //pageEA.FillUserForm("M.Ż", "Mateusz", "Żarczyński"); //dane wprowadzene z visuala 
            
            // initialize the page by calling its reference

            //EAPageObject page = new EAPageObject();

            //page.txtInitial.SendKeys("Mateusz.Ż");
            //Console.WriteLine("Wprowadzan Inicjał");
            //page.btnSave.Click();
            //Console.WriteLine("Kilkam Save");
            
            
            
            ////Title 
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //// Initial
            //SeleniumSetMethods.EnterText("Initial", "M.Ż", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void ClenUp()
        {
            PropertiesToChromeDriver.chrome.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
