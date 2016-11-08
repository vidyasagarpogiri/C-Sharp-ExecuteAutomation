using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesToChromeDriver.chrome, this);
        }


        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login (string userName, string password) // zamiast voida dajemy EaPageObject, czyliz wroci nam widok po zalogowaniu
        {


            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            btnLogin.Submit();
            
            
            
            
            ////UserName
            //SeleniumSetMethods.EnterText(txtUserName, userName);
            ////Password
            //SeleniumSetMethods.EnterText(txtPassword, password);
            ////Click button
            //btnLogin.Submit();
            

            // Return a new object 
            return new EAPageObject();                                  //zwraca obiekz ze EaPageObject
        }
    
    }
}
