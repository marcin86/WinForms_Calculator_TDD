using CalculatorLogic.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLogicTests.OperationsTests
{
    [TestClass]
    public class MultiplyTests
    {
        private ICalculatorLogic defaultImplementation = new DefaultImplementation();

        [DataTestMethod]
        [DataRow(10f, 5f, 50f)]
        [DataRow(11.88f, 3f, 35.64f)]
        [DataRow(5.55f, 3.66f, 20.313f)]
        [DataRow(.55f, 8f, 4.4f)]
        [DataRow(.88f, .36f, 0.317f)]
        [DataRow(10.297f, 33.1f, 340.831f)]
        [DataRow(0.6f, 0.3f, 0.18f)]
        public void CorrectInput_CorrectResult(float lhs, float rhs, float expectedResult)
        {
            // Arrange, Act
            float result = defaultImplementation.Multiply(lhs, rhs);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ResultBiggerThanFloatMaxValue_Overflow()
        {
            // Arrange
            float lhs = float.MaxValue, rhs = 1.01f;

            // Act, Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => defaultImplementation.Multiply(lhs, rhs));
        }
    }
}
