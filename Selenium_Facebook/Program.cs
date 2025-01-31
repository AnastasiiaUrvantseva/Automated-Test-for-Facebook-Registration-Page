using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Facebook
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // Go to Facebook Page
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.facebook.com/?locale=en_US");
        }

        [Test]
        public void ExecuteTest()
        {
            // Make browser full screen
            driver.Manage().Window.Maximize();

            IWebElement CreateNewAccount = driver.FindElement(By.CssSelector("a[data-testid = 'open-registration-form-button']"));
            CreateNewAccount.Click();

            IWebElement FirstName = driver.FindElement(By.Name("firstname"));
            FirstName.SendKeys("Ana");

            IWebElement LastName = driver.FindElement(By.Name("lastname"));
            LastName.SendKeys("Wick");

            IWebElement Email = driver.FindElement(By.Name("reg_email__"));
            Email.SendKeys("anawick@gmail.com");

            IWebElement Password = driver.FindElement(By.Name("reg_passwd__"));
            Password.SendKeys("myawesomepassword");

            IWebElement Month = driver.FindElement(By.Id("month"));
            var selectElementMonth = new SelectElement(Month);
            selectElementMonth.SelectByValue("12");

            IWebElement Day = driver.FindElement(By.Id("day"));
            var selectElementDay = new SelectElement(Day);
            selectElementDay.SelectByValue("7");

            IWebElement Year = driver.FindElement(By.Id("year"));
            var selectElementYear = new SelectElement(Year);
            selectElementYear.SelectByValue("2005");

            IWebElement GenderButton = driver.FindElement(By.Id("sex"));
            GenderButton.Click();

            IWebElement SignUpButton = driver.FindElement(By.Name("websubmit"));
            SignUpButton.Click();

            Thread.Sleep(10000);

            //For verigying an error message for fake account:
            //IWebElement ErrorMessage = driver.FindElement(By.XPath("//*[@id=\"reg\"]/div/div"));
            //Assert.That(ErrorMessage.Text.Contains("Sorry, we are not able to process your registration."));

        }

        [TearDown] 
        public void CloseTest()
        {
            // Close the browser
            driver.Quit();
        }
    }
}
