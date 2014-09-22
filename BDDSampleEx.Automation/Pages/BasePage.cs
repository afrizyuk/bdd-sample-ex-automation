using System;
using BDDSampleEx.Automation.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver {get { return Browser.Driver(); }}
        
        protected BasePage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public string CurrentUrl
        {
            get { return Driver.Url; }
            internal set{Driver.Navigate().GoToUrl(value);}
        }

        public void OpenMainPage()
        {
            Driver.Navigate().GoToUrl(Browser.StartPage);
        }

        public void OpenMainPage(string ending)
        {
            Driver.Navigate().GoToUrl(Browser.StartPage + ending);
        }


    }
}
