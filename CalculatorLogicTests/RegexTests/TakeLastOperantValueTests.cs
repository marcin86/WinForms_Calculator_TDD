using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class TakeLastOperantValueTests
    {
        private const string pattern = @"^[+-]?([0-9]*[.]?[0-9]{1,}) [+-\/*] [+-]?([0-9]*[.]?[0-9]{1,})+$";
        private IRegexOperations regex = null;

        [TestInitialize]
        public void Setup()
        {
            regex = new RegexImplementation();
        }

        [DataTestMethod]
        [DataRow("123.43 + 3233.33", pattern, 3233.33f)]
        [DataRow("12.2 - 3333", pattern, 3333f)]
        [DataRow("333 / 444.4444", pattern, 444.4444f)]
        [DataRow(".777 + 555", pattern, 555f)]
        [DataRow("333 / .4444", pattern, .4444f)]
        public void CorrectInput_CorrectValue(string source, string pattern, float expectedResult)
        {
            // Arrange, Act
            float result = regex.TakeLastOperantValue(source, pattern);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow("3233.33", pattern)]
        [DataRow("3333", pattern)]
        [DataRow("333 /", pattern)]
        [DataRow(".777 +", pattern)]
        public void IncorrectInput_NaN(string source, string pattern)
        {
            // Arrange, Act
            float result = regex.TakeLastOperantValue(source, pattern);

            // Assert
            Assert.AreEqual(float.NaN, result);
        }
    }
}
