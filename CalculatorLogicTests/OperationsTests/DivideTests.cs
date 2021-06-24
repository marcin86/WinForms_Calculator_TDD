using CalculatorLogic.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLogicTests.OperationsTests
{
    [TestClass]
    public class DivideTests
    {
        private ICalculatorLogic defaultImplementation = new DefaultImplementation();

        [DataTestMethod]
        [DataRow(10f, 5f, 2f)]
        [DataRow(11.88f, 3f, 3.96f)]
        [DataRow(5.55f, 3.66f, 1.516f)]
        [DataRow(.55f, 8f, 0.069f)]
        [DataRow(.88f, .36f, 2.444f)]
        [DataRow(0.6f, 0.3f, 2f)]
        public void CorrectInput_CorrectResult(float lhs, float rhs, float expectedResult)
        {
            // Arrange, Act
            float result = defaultImplementation.Divide(lhs, rhs);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AttemptToDivideByZero_DivideByZeroException()
        {
            // Arrange
            float lhs = 1f, rhs = 0f;

            // Act, Assert
            Assert.ThrowsException<DivideByZeroException>(() => defaultImplementation.Divide(lhs, rhs));
        }

        [TestMethod]
        public void ResultBiggerThanFloatMaxValue_Overflow()
        {
            // Arrange
            float lhs = float.MaxValue, rhs = 0.1f;

            // Act, Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => defaultImplementation.Divide(lhs, rhs));
        }
    }
}
