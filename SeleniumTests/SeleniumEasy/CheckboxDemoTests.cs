using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckboxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            CheckboxDemo.Open();
        }

        [Test]
        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckboxDemo.ClickSingleCheckbox();
            string actualResult = CheckboxDemo.GetSingleCheckboxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckboxDemo.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
