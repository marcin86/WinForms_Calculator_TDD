using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class AreBothOperantsPresentTests
    {
        private const string pattern = @"^([+-]?([0-9]*[.])?[0-9]+) [+-\/*] ([+-]?([0-9]*[.])?[0-9]+)$";
        private IRegexOperations regex = null;

        [TestInitialize]
        public void Setup()
        {
            regex = new RegexImplementation();
        }

        [DataTestMethod]
        [DataRow("123 + 123", pattern)]
        [DataRow("31231231 + 4355345355", pattern)]
        public void TwoCorrectOperantsPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.AreBothOperantsPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("123 + 123.456", pattern)]
        [DataRow("312.17 + 4355345355", pattern)]
        public void FloatAndNonFloatOperantsPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.AreBothOperantsPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("123.45 + 123.33", pattern)]
        [DataRow("31231231.11 + 4355345355.5555", pattern)]
        public void CorrectFloatOperantsPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.AreBothOperantsPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("123 + 11a", pattern)]
        [DataRow("11a + 123", pattern)]
        [DataRow("aa + bb", pattern)]
        [DataRow("123 + 123 ", pattern)]
        [DataRow(" 123 + 123", pattern)]
        public void OneOrTwoIncorrectOperantPresent_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.AreBothOperantsPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }

        [DataTestMethod]
        [DataRow("", pattern)]
        [DataRow("123 ", pattern)]
        [DataRow("123 +", pattern)]
        [DataRow("123 + 123 +", pattern)]
        public void IncorrectInputs_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.AreBothOperantsPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
