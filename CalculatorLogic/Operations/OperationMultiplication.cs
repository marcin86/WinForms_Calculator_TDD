using CalculatorLogic.Logic;

namespace CalculatorLogic.Operations
{
    public class OperationMultiplication : MathematicalOperationBase
    {
        public OperationMultiplication(ICalculatorLogic logic) : base(logic)
        {
        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Multiply(lhs, rhs);
        }
    }
}
