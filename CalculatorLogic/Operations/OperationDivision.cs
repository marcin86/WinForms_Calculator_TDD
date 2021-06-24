using CalculatorLogic.Logic;

namespace CalculatorLogic.Operations
{
    public class OperationDivision : MathematicalOperationBase
    {
        public OperationDivision(ICalculatorLogic logic) : base(logic)
        {
        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Divide(lhs, rhs);
        }
    }
}
