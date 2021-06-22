using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class IsTheLastSymbolAnOperationSymbolTests
    {
        private const string pattern = @"^[+-]?([0-9]*[.])?[0-9]+ [+-\/*] $";
        private IRegexOperations regex = null;

        [TestInitialize]
        public void Setup()
        {
            regex = new RegexImplementation();
        }

        [DataTestMethod]
        [DataRow("123 + ", pattern)]
        [DataRow("123 - ", pattern)]
        [DataRow("123 * ", pattern)]
        [DataRow("123 / ", pattern)]
        public void LastSymbolIsOperationSymbol_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsTheLastSymbolAnOperationSymbol(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("123.12 + ", pattern)]
        [DataRow("0.12 - ", pattern)]
        [DataRow("00.121212 * ", pattern)]
        [DataRow("123.11111111111111111111111 / ", pattern)]
        public void FloatOperantsAndOperationSymbol_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsTheLastSymbolAnOperationSymbol(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("123 +", pattern)]
        [DataRow("123 -", pattern)]
        [DataRow("123 *", pattern)]
        [DataRow("123 /", pattern)]
        public void TrailingWhiteCharacterIsMissing_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsTheLastSymbolAnOperationSymbol(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }

        [DataTestMethod]
        [DataRow("123 + 123 +", pattern)]
        [DataRow("123 + 123 + ", pattern)]
        [DataRow("+ 123", pattern)]
        public void IncorrectInputs_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsTheLastSymbolAnOperationSymbol(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
