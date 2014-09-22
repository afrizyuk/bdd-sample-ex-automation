using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GmailAuto.core
{
    public static class WebElementExtensions
    {
        public static int DefaultTimeOutMilliseconds = 10000;

        public static IWebElement WaitUntilVisible(this IWebElement element, TimeSpan timeOut)
        {
            return Wait.UntilVisible(element, timeOut);
        }

        public static IWebElement WaitUntilVisible(this IWebElement element, int timeOutMilliseconds)
        {
            return Wait.UntilVisible(element, TimeSpan.FromMilliseconds(timeOutMilliseconds));
        }

        public static IWebElement WaitUntilVisible(this IWebElement element)
        {
            return Wait.UntilVisible(element, TimeSpan.FromMilliseconds(DefaultTimeOutMilliseconds));
        }
    }
}
