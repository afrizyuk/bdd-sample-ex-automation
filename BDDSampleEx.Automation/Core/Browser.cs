using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace BDDSampleEx.Automation.Core
{
    public class Browser
    {
        private static IWebDriver _driver;
        public static readonly string StartPage = 
            System.Configuration.ConfigurationManager.AppSettings["StartPage"];

        public static IWebDriver Driver()
        {
            if (_driver == null)
            {
                var browser = System.Configuration.ConfigurationManager.AppSettings["Browser"];

                switch (browser)
                {
                    case "FireFox":
                        _driver = new FirefoxDriver();
                        break;
                    case "GoogleChrome":
                        _driver = new ChromeDriver();
                        break;
                    case "IExplorer":
                        _driver = new InternetExplorerDriver();
                        break;
                }

                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void Close()
        {
            if (_driver != null)
                _driver.Close();
        }

        static readonly Finalizer finalizer = new Finalizer();

        sealed class Finalizer
        {
            ~Finalizer()
            {
                Close();
            }
        }
    }

}
