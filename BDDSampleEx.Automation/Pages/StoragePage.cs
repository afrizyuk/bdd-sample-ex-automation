using GmailAuto.core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class StoragePage : BasePage
    {
        //locators
        [FindsBy(How = How.XPath, Using = "//a[starts-with(@href,'/delete_object/')]")] 
        private IWebElement deleteStorageButton = null;

        [FindsBy(How = How.XPath, Using = "//td[@id='body_element']/b")] 
        private IWebElement storageIdLabel = null;


        public void DeleteStorage()
        {
            deleteStorageButton.WaitUntilVisible().Click();

            if (Driver.SwitchTo().Alert() != null)
            {
                IAlert alert = Driver.SwitchTo().Alert();
                //var alertMessage = alert.Text;
                alert.Accept();
            }
        }

        public string StorageID
        {
            get { return storageIdLabel.WaitUntilVisible().Text; }
        }
    }
}
