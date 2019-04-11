

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BDDSpeckFlowProject
{
   public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
           // PageFactory.InitElements(_Driver.firefox, this);

        }
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement Search { get; set; }

        [FindsBy(How = How.Id, Using = "creation_hub_entrypoint")]
        public IWebElement Profile { get; set; }

        [FindsBy(How = How.Id, Using = "u_1w_0")]
        public IWebElement Profilename { get; set; }
       
    }
}
