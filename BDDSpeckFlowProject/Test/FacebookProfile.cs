

using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDSpeckFlowProject.Test
{
    [Binding]
    public class FacebookProfile 
    {
            [Given(@"The User login to facebook")]
            public void GivenTheUserlogintofacebook()
            {
                Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseUrl"]);
            Driver.driver.Manage().Window.Maximize();
            LoginPage login = new LoginPage();
                login.Email.SendKeys(ConfigurationManager.AppSettings["username"]);
                login.Passwword.SendKeys(ConfigurationManager.AppSettings["password"]);
                 login.LoginButton.Click();
                    Thread.Sleep(3000);

           
         


        }

            [When(@"The user clicks on profile")]
            public void WhenTheuserclicksonprofile()
            {
            HomePage homepage = new HomePage();
            //homepage.Profile.Click();
            //Thread.Sleep(3000);

        }

            [Then(@"The user should be navigated to profile")]
            public void Theusershouldbenavigatedtoprofile()
            {
            /// HomePage homepage = new HomePage();
            // homepage.Profilename.Click();

            Driver.driver.Close();

            }
        }
}
