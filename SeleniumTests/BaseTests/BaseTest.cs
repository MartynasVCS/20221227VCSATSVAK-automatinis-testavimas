using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenshot();
                TestContext.AddTestAttachment(fileName);
            }
            Driver.CloseDriver();
        }
    }
}
