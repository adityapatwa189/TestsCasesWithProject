using NUnit.Framework;
using PractiseTests;
namespace PracticeTestNunit
{
    [TestFixture]
    public class UnitTest2
    {
        SumOfDigits obj;
        [SetUp]
        public void Init()
        {
            obj = new SumOfDigits();
        }
        [Test]
        [TestCase(12,3)]
        [TestCase(92,2)]
        [TestCase(973,1)]
        public void Check_SumOfDigits_UpToSingleDigit(int number, int expectedResult)
        {
            var result = obj.DigitSum(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

