using BDDSampleEx.Automation.Pages;
using NUnit.Framework;

namespace Ex.Tests
{
    [TestFixture]
    public class SimpleTest
    {

        [Test]
        public void FirstTest()
        {
            var homePage = new HomePage();
            homePage.GoTo(Menu.Search);
        }

        [Test]
        public void CanReadAppConfi()
        {
            var browser  = System.Configuration.ConfigurationManager.AppSettings["Browser"];
            Assert.AreEqual("FireFox", browser, "Isn't matched");
        }
    }
}
