using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using GmailAuto.core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class StorageIsNotFoundPage : BasePage
    {
        //locators
        [FindsBy(How = How.Id, Using = "message")] 
        private IWebElement objectIsNotFoundLabel = null;


        public bool IsAt
        {
            get { return objectIsNotFoundLabel.WaitUntilVisible().Displayed; }
        }
    }
}
