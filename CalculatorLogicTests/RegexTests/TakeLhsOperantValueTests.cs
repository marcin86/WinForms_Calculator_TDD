using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class TakeLhsOperantValueTests
    {
        private const string pattern = @"^[+-]?([0-9]*[.])?[0-9]+$";
        private IRegexOperations regex = null;

        [TestInitialize]
        public void Setup()
        {
            regex = new RegexImplementation();
        }

        [DataTestMethod]
        [DataRow("12", pattern, 12.00f)]
        [DataRow("123.99", pattern, 123.99f)]
        [DataRow("12345", pattern, 12345f)]
        public void CorrectInput_CorrectValue(string source, string pattern, float expectedResult)
        {
            // Arrange, Act
            float result = regex.TakeLhsOperantValue(source, pattern);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow("12a", pattern)]
        [DataRow("123,99", pattern)]
        [DataRow("ccc", pattern)]
        [DataRow("", pattern)]
        public void IncorrectInput_Nan(string source, string pattern)
        {
            // Arrange, Act
            float result = regex.TakeLhsOperantValue(source, pattern);

            // Assert
            Assert.AreEqual(float.NaN, result);
        }
    }
}
