using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BDDSpeckFlowProject
{
   public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);

            //PageFactory.InitElements(_Driver.firefox, this);
        }
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.Name, Using = "pass")]
        public IWebElement Passwword { get; set; }
        [FindsBy(How = How.Id, Using = "loginbutton")]
        public IWebElement LoginButton { get; set; }

        
           
    }
}
