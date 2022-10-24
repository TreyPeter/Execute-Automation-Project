using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Execute_Automation.Pages
{
    class LoginPage
    {

        public LoginPage(IWebDriver driver)
        {

            WebDriver = driver;

        }

        public IWebDriver WebDriver { get; }

       
        IWebElement txtUserName => WebDriver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));

        IWebElement btnLogin => WebDriver.FindElement(By.XPath("//input[@value='Log in']"));


        public void Login(string username, string password)
        {


            txtUserName.SendKeys("admin");

            Task.Delay(2000).Wait();

            txtPassword.SendKeys("password");

            Task.Delay(2000).Wait();

            btnLogin.Submit();

        }

        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            WebDriver.Close();
        }


    }
}
