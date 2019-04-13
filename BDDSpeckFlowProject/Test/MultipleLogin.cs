using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDSpeckFlowProject.Test
{
    [Parallelizable]
    [Binding]
    public class MultipleLogin

    {
        public IWebDriver Driver { get; set;}
        [Given(@"The User Navigates tru facebook")]
        public void GivenTheUserNavigatestruFacebook()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseUrl"]);           
            Thread.Sleep(1000);
        }
        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string usename, string password)
        {
            LoginPage login = new LoginPage(Driver);
            login.Email.SendKeys(usename);
            login.Passwword.SendKeys(password);
            Thread.Sleep(1000);
        }
        [Then(@"the user can clear road")]
        public void theusercanclearroad()
        {
            LoginPage login = new LoginPage(Driver);
          
            login.Email.Clear();
            login.Passwword.Clear();
            Driver.Close();

        }
        }
}
