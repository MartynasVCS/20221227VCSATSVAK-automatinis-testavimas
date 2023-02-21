using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SelectDropdownListTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SelectDropdownList.Open();
        }

        [Test]
        public void SelectDay()
        {
            string expectedDay = "Tuesday";

            SelectDropdownList.SelectDay(expectedDay);
            string actualResult = SelectDropdownList.GetSelectedDay();

            Assert.IsTrue(actualResult.Contains(expectedDay));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
