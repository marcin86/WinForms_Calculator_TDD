using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLogicTests
{
    [TestClass]
    public class Add
    {
        [TestMethod]
        public void AddTwoPositiveCorrectValues()
        {
            // Arrange
            float lhs = 5.20f, rhs = 3.33f, result = 0.0f;
            CalculatorLogic.DefaultImplementation defaultImplementation = new CalculatorLogic.DefaultImplementation();

            // Act
            result = defaultImplementation.Add(lhs, rhs);

            // Assert
            Assert.AreEqual((lhs + rhs), result);
        }
    }
}
