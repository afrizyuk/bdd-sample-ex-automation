using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GmailAuto.core
{
    public static class Wait
    {
        public static IWebElement UntilVisible(IWebElement element, TimeSpan timeOut)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                WebDriverException lastException = null;
                try
                {
                    if (element.Displayed)
                    {
                        return element;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                catch (ElementNotVisibleException e)
                {
                    lastException = e;
                }

                catch (NoSuchElementException e)
                {
                    lastException = e;
                }

                catch (StaleElementReferenceException e)
                {
                    lastException = e;
                }

                if (stopwatch.Elapsed > timeOut)
                {
                    string exceptionMessage = lastException == null ? "" : lastException.Message;
                    string errorMessage = string.Format("Wait.UntilVisible: Element was not displayed after {0} Milliseconds" +
                                                        "\r\n Error Message:\r\n{1}", timeOut.TotalMilliseconds, exceptionMessage);
                    throw new TimeoutException(errorMessage);
                }
            }
        }

        public static IWebElement UntilVisible(IWebElement element, int timeOutMilliseconds)
        {
            return UntilVisible(element, TimeSpan.FromMilliseconds(timeOutMilliseconds));
        }
    }
}
