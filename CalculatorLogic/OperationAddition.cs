namespace CalculatorLogic
{
    public class OperationAddition : MathematicalOperationBase
    {
        public OperationAddition(): base(new DefaultImplementation())
        {

        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Add(lhs, rhs);
        }
    }
}
