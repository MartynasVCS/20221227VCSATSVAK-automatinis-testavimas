using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class JavascriptsAlertsTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            JavascriptAlerts.Open();
        }

        [Test]
        public void TestJavascriptAlerts()
        {
            string expectedValue = "I am an alert box!";

            JavascriptAlerts.OpenSimpleAlert();
            string actualValue = JavascriptAlerts.GetAlertText();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
