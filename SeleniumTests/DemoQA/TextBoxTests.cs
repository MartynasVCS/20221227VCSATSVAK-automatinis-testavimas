using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            TextBox.Open();
        }

        [Test]
        public void FillFormWithValidEmail()
        {
            string valueInputName = "My Name";
            string valueInputEmail = "email@email.com";
            string valueInputCurrentAddress = "My current address";
            string valueInputPermanentAddress = "My permanent address";

            TextBox.EnterFullName(valueInputName);
            TextBox.EnterEmail(valueInputEmail);
            TextBox.EnterCurrentAddress(valueInputCurrentAddress);
            TextBox.EnterPermanentAddress(valueInputPermanentAddress);
            TextBox.ClickSubmitButton();

            string actualFullName = TextBox.GetFullNameOutput();
            string actualEmail = TextBox.GetEmailOutput();
            string actualCurrentAddress = TextBox.GetCurrentAddressOutput();
            string actualPermanentAddress = TextBox.GetPermanentAddressOutput();

            Assert.IsTrue(actualFullName.Contains(valueInputName));
            Assert.IsTrue(actualEmail.Contains(valueInputEmail));
            Assert.IsTrue(actualCurrentAddress.Contains(valueInputCurrentAddress));
            Assert.IsTrue(actualPermanentAddress.Contains(valueInputPermanentAddress));
        }

        [Test]
        public void FillFormWithInvalidEmail()
        {
            string valueInputEmail = "invalidEmail";

            TextBox.EnterEmail(valueInputEmail);
            TextBox.ClickSubmitButton();

            Assert.IsTrue(TextBox.CheckIfEmailErrorIsDisplayed());
            Assert.IsTrue(TextBox.CheckIfEmailBorderIsRed());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
