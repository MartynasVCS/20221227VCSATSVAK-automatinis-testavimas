using NUnit.Framework;

namespace CalculatorUnitTests
{
    internal class Homework1
    {
        [Test]
        public void CheckRemainder995DividedBy3()
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
