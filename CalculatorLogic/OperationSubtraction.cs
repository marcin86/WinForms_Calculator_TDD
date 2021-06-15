namespace CalculatorLogic
{
    public class OperationSubtraction : MathematicalOperationBase
    {
        public OperationSubtraction(ICalculatorLogic logic): base(logic)
        {
            
        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Subtract(lhs, rhs);
        }
    }
}
