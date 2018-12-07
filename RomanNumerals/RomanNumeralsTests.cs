using NUnit.Framework;
namespace RomanNumerals
{
    using static RomanNumerals;

    public class RomanNumeralsTests
    {
        [Test]
        [TestCase(0,ExpectedResult = "")]
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(16, ExpectedResult = "XVI")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(500, ExpectedResult = "D")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(1678, ExpectedResult = "MDCLXXVIII")]
        public string TestConversion(int numericNumber)
        {
            return ConvertToRomanNumeral(numericNumber);
        }
    }
}