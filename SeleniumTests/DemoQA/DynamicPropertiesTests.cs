using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumFramework;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeClickable()
        {
            Assert.IsTrue(DynamicProperties.WaitForButtonToBeClickable());
        }

        [Test]
        public void WaitForButtonClassToChange()
        {
            DynamicProperties.WaitForButtonClassToChange();
        }

        [Test]
        public void WaitForButtonBorderToBeRed()
        {
            DynamicProperties.WaitForButtonTextToBeRed();
        }

        [Test]
        public void WaitForButtonToBeVisible()
        {
            DynamicProperties.WaitForButtonToBeVisible();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
