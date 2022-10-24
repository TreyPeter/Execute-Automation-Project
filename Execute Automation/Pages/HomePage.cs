using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Execute_Automation.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

       private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement LnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLoigin() => lnkLogin.Click();

        public bool IsEmployeerDetailsExst() => LnkEmployeeDetails.Displayed;


        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            Driver.Close();
        }
    }
}
