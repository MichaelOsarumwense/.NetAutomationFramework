

using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDSpeckFlowProject
{
    [Parallelizable]
    [Binding]
   public class FaceBookLogin
    {
        public IWebDriver Driver { get; set; }
        [Given(@"The User Navigates to facebook")]
        public void GivenTheUserNavigatestoFacebook()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["FoxUrl"]);
            Thread.Sleep(1000);
        }

        [When(@"The user enters correct username")]
        public void AndTheUserenterscorrectUsername()
        {
            LoginPage login = new LoginPage(Driver);
            login.Email.SendKeys(ConfigurationManager.AppSettings["username"]);
            Thread.Sleep(1000);
        }

        [When(@"The user enters correct password")]
        public void AndTheUserenterscorrectPassword()
        {
            LoginPage login = new LoginPage(Driver);
            login.Passwword.SendKeys(ConfigurationManager.AppSettings["password"]);
            Thread.Sleep(1000);
        }

      
        [Then(@"the user should be logged in")]
        public void Thentheusershouldbeloggedin()
        {
            LoginPage login = new LoginPage(Driver);
            login.LoginButton.Click();
            //login.LoginButton.Should().NotBeNull();

            Driver.Close();

        }
    }
        }
        
