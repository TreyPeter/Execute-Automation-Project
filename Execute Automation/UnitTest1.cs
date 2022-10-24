using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading.Tasks;

namespace Execute_Automation
{
    public class Tests
    {

        WebDriver webDriver = new ChromeDriver(@"C:\Users\DELL\Downloads\Driver");

        [SetUp]
        public void Setup()
        {

            


        }

        [Test]
        public void Test1()
        {
                          
                        
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            webDriver.Manage().Window.Maximize();

            Task.Delay(2000).Wait();

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            Task.Delay(2000).Wait();

            lnkLogin.Click();

            var txtUserName = webDriver.FindElement(By.Name("UserName"));

            Task.Delay(2000).Wait();

            Assert.That(txtUserName.Displayed, Is.True);

            Task.Delay(2000).Wait();

            txtUserName.SendKeys("admin");

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

            var LnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            Assert.That(LnkEmployeeDetails.Displayed, Is.True);

            

            var lnkAbout = webDriver.FindElement(By.LinkText("About"));

            Task.Delay(2000).Wait();
            webDriver.FindElement(By.LinkText("About")).Click();

            Task.Delay(2000).Wait();

            var About = webDriver.FindElement(By.LinkText("About"));

            webDriver.FindElement(By.LinkText("Employee List")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.LinkText("Employee Details")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.LinkText("Manage Users")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.LinkText("Hello admin!")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.LinkText("Log off")).Click();

                                 

        }

        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            webDriver.Close();
        }



    }
}