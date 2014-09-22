using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDSampleEx.Automation.Pages
{
    public class StorageEditPage : BasePage
    {
        //locators
        [FindsBy(How = How.Id, Using = "uploadTable")]
        private IWebElement uploadTable = null;

        [FindsBy(How = How.XPath, Using = "//td[@id='body_element']/table[1]/tbody/tr[2]/td[2]/b")] 
        private IWebElement accessKeyLabel = null;

        public string FileStatus(string fileName)
        {
            var xpath = @"//*[@title='" + fileName + "']/../td[starts-with(@id,'uploadStatus')]";
            var fileLabel = uploadTable.FindElement(By.XPath(xpath));
            return fileLabel.Text;
        }

        public string StorageAccessKey
        {
            get
            {
                Thread.Sleep(2000);
                return accessKeyLabel.Text;
            }
        }
    }
}
