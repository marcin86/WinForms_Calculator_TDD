using CalculatorLogic.RegexAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests.RegexTests
{
    [TestClass]
    public class IsLhsOperantPresentTests
    {
        [DataTestMethod]        
        [DataRow("12", @"^\d+$")]
        [DataRow("123", @"^\d+$")]
        [DataRow("12345", @"^\d+$")]
        public void CorrectOperantPresent_ReturnTrue(string source, string pattern)
        {
            // Arrange
            IRegexOperations regex = new RegexImplementation();

            // Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("aa", @"^\d+$")]
        [DataRow(" 123", @"^\d+$")]
        [DataRow("123 ", @"^\d+$")]
        [DataRow("1a2b3c", @"^\d+$")]
        public void IncorrectOperantPresent_ReturnFalse(string source, string pattern)
        {
            // Arrange
            IRegexOperations regex = new RegexImplementation();

            // Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }

        [DataTestMethod]
        [DataRow("", @"^\d+$")]
        [DataRow("", @"^\d+$")]
        [DataRow("", @"^\d+$")]
        public void EmptyInput_ReturnFalse(string source, string pattern)
        {
            // Arrange
            IRegexOperations regex = new RegexImplementation();

            // Act
            bool result = regex.IsLhsOperantPresent(source, pattern);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
