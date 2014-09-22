using GmailAuto.core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class SearchPage : BasePage
    {
        //locators

        [FindsBy(How = How.Id, Using = "search_text")] 
        private IWebElement search_textInput = null;

        [FindsBy(How = How.Id, Using = "search_button")] 
        private IWebElement search_button = null;

        public void EnterSearchText(string search_text)
        {
            search_textInput.WaitUntilVisible().SendKeys(search_text);
        }

        public void ClickSearch()
        {
            search_button.Click();
        }
    }
}
