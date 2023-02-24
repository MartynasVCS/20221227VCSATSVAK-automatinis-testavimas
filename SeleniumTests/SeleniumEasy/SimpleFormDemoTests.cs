using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("7", "5", "12")]
        [TestCase("7", "a", "NaN")]
        [TestCase("-11111111111111111111111", "11111111111111111111111", "0")]
        public void TwoInputFields(string inputAValue, string inputBValue, string expectedResult)
        {
            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
