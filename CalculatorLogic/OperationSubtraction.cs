namespace CalculatorLogic
{
    public class OperationSubtraction : MathematicalOperationBase
    {
        public OperationSubtraction(): base(new DefaultImplementation())
        {
            
        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Subtract(lhs, rhs);
        }
    }
}
