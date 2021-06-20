using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLogic.Logic;

namespace CalculatorLogicTests.OperationsTests
{
    [TestClass]
    public class SubtractTests
    {
        private ICalculatorLogic defaultImplementation = new DefaultImplementation();

        [TestMethod]
        public void RemoveSmallerFromBigger_CorrectResult()
        {
            // Arrange
            float lhs = 5.20f, rhs = 3.33f, result = 0.0f;

            // Act
            result = defaultImplementation.Subtract(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs - rhs), result);
        }

        [TestMethod]
        public void RemoveBiggerFromSmaller_CorrectResult()
        {
            // Arrange
            float lhs = 5.50f, rhs = 500.20f, result = 0.0f;

            // Act
            result = defaultImplementation.Subtract(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs - rhs), result);
        }

        [TestMethod]
        public void RemoveNegativeFromPositive_CorrectResult()
        {
            // Arrange
            float lhs = 500.12f, rhs = -44f, result = 0.0f;

            // Act
            result = defaultImplementation.Subtract(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs - rhs), result);
        }

        [TestMethod]
        public void RemovePositiveFromNegative_CorrectResult()
        {
            // Arrange
            float lhs = -500.12f, rhs = 44.86f, result = 0.0f;

            // Act
            result = defaultImplementation.Subtract(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs - rhs), result);
        }

        [TestMethod]
        public void RemoveTwoExponentialValues_CorrectResult()
        {
            // Arrange
            float lhs = 3.8E20f, rhs = 1.5E-4f, result = 0.0f;

            // Act
            result = defaultImplementation.Subtract(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void RemoveFromMinimalPossibleValue_Underflow()
        {
            // Arrange
            float lhs = float.MinValue, rhs = 1E23f;

            // Act, Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => defaultImplementation.Subtract(lhs, rhs));
        }
    }
}
