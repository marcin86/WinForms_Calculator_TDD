using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class IsLhsOperantPresentTests
    {
        private const string pattern = @"^[+-]?([0-9]*[.]?[0-9]{1,})$";
        private IRegexOperations regex = null;

        [TestInitialize]
        public void Setup()
        {
            regex = new RegexImplementation();
        }

        [DataTestMethod]        
        [DataRow("12", pattern)]
        [DataRow("123", pattern)]
        [DataRow("12345", pattern)]
        public void CorrectOperantPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("12.34567", pattern)]
        [DataRow("123.09", pattern)]
        [DataRow("12345.007", pattern)]
        public void CorrectFloatOperantPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("aa", pattern)]
        [DataRow(" 123", pattern)]
        [DataRow("123 ", pattern)]
        [DataRow("1a2b3c", pattern)]
        public void IncorrectOperantPresent_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }

        [DataTestMethod]
        [DataRow("", pattern)]
        [DataRow("", pattern)]
        [DataRow("", pattern)]
        public void EmptyInput_ReturnFalse(string source, string pattern)
        {
            // Arrange, Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
