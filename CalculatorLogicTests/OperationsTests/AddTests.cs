using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic.Logic;
using System;

namespace CalculatorLogicTests.OperationsTests
{
    [TestClass]
    public class AddTests
    {
        private ICalculatorLogic defaultImplementation = new DefaultImplementation();

        [TestMethod]
        public void AddTwoPositiveCorrectValues_CorrectResult()
        {
            // Arrange
            float lhs = 5.20f, rhs = 3.33f, result = 0.0f;    

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void AddTwoNegativeCorrectValues_CorrectResult()
        {
            // Arrange
            float lhs = -4.50f, rhs = -5.20f, result = 0.0f;

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void AddPositiveAndNegativeValues_CorrectResult()
        {
            // Arrange
            float lhs = 200.34f, rhs = -59.92f, result = 0.0f;

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void AddNegativeAndPositiveValues_CorrectResult()
        {
            // Arrange
            float lhs = 200.34f, rhs = -59.92f, result = 0.0f;

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void AddTwoExponentialValues_CorrectResult()
        {
            // Arrange
            float lhs = 3.8E20f, rhs = 1.5E-4f, result = 0.0f;

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }

        [TestMethod]
        public void AddMaxPossibleValueAndOne_Overflow()
        {
            // Arrange
            float lhs = float.MaxValue, rhs = 1E23f;

            // Act, Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => defaultImplementation.Add(lhs, rhs));
        }
    }
}
