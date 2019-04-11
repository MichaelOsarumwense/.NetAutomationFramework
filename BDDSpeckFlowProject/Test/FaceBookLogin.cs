

using FluentAssertions;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDSpeckFlowProject
{

   [Binding]
    class FaceBookLogin
    {

        [Given(@"The User Navigates to facebook")]
        public void GivenTheUserNavigatestoFacebook()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["FoxUrl"]);
            Driver.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"The user enters correct username")]
        public void AndTheUserenterscorrectUsername()
        {
            LoginPage login = new LoginPage();
            login.Email.SendKeys(ConfigurationManager.AppSettings["username"]);
            Thread.Sleep(1000);
        }

        [When(@"The user enters correct password")]
        public void AndTheUserenterscorrectPassword()
        {
            LoginPage login = new LoginPage();
            login.Passwword.SendKeys(ConfigurationManager.AppSettings["password"]);
            Thread.Sleep(1000);
        }

      
        [Then(@"the user should be logged in")]
        public void Thentheusershouldbeloggedin()
        {
            LoginPage login = new LoginPage();
            login.LoginButton.Should().NotBeNull();
           


            Thread.Sleep(1000);
            Driver.driver.Close();

        }
    }
        }
        
