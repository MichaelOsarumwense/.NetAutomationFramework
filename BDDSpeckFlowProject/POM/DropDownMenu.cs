using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace BDDSpeckFlowProject
{
   public class DropDownMenu
    {
        public DropDownMenu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

           // PageFactory.InitElements(_Driver.firefox, this);
        }
            [FindsBy(How = How.Id, Using = "userNavigationLabel")]
        public IWebElement DropdownButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "_54nh")]
        public IWebElement LogoutButton { get; set; }
    }

    }

