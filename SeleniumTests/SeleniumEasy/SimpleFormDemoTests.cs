using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [Test]
        public void SingleInputField()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();
            
            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }

        [Test]
        public void TwoInputFields()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string inputAValue = "5";
            string inputBValue = "7";
            string expectedResult = "12";

            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }
    }
}
