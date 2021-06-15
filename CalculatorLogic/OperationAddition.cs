namespace CalculatorLogic
{
    public class OperationAddition : MathematicalOperationBase
    {
        public OperationAddition(ICalculatorLogic logic): base(logic)
        {

        }

        public override float CalculateResult(float lhs, float rhs)
        {
            return calculatorLogic.Add(lhs, rhs);
        }
    }
}
