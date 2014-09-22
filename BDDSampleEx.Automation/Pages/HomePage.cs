using System;
using System.Security.Cryptography;
using GmailAuto.core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class HomePage : BasePage
    {
        //Locators
        [FindsBy(How = How.XPath, Using = "//a[@href='/search']")] 
        private IWebElement searchLink = null;
        
        [FindsBy(How = How.XPath, Using = "//input[@class=\"button ex\"]")] 
        private IWebElement newStorageButton = null;

        [FindsBy(How = How.Name, Using = "key")] 
        private IWebElement keyInput = null;

        [FindsBy(How = How.XPath, Using = "//input[@value='receive']")] 
        private IWebElement receiveButton = null;


        public void GoTo(Menu menu)
        {
            switch (menu)
            {
                case Menu.Search:
                    searchLink.WaitUntilVisible().Click();
                    break;
                case Menu.Files:
                    throw new NotImplementedException();
                case Menu.Mail:
                    throw new NotImplementedException();
            }
        }

        public string CreateNewStorage()
        {
            newStorageButton.WaitUntilVisible().Click();
            return Page<StorageEditPage>.Instance().StorageAccessKey;
        }

        public void GetStorageByKey(string accessKey)
        {
            keyInput.WaitUntilVisible().SendKeys(accessKey);
            receiveButton.Click();
        }
        
    }

    public enum Menu
    {
        Mail
        ,Files
        ,Search
    }
}
