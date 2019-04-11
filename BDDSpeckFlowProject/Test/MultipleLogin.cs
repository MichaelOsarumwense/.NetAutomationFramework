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
    [Binding]
    public class MultipleLogin
        
    {

        [Given(@"The User Navigates tru facebook")]
        public void GivenTheUserNavigatestruFacebook()
        {
            
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseUrl"]);
            Driver.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string username, string password)
        {
            LoginPage login = new LoginPage();
            login.Email.SendKeys(username);
            login.Passwword.SendKeys(password);
            Thread.Sleep(3000);
        }
        [Then(@"the user can clear road")]
        public void theusercanclearroad()
        {
            LoginPage login = new LoginPage();
          
            login.Email.Clear();
            login.Passwword.Clear();
            Driver.driver.Close();

        }
        }
}
