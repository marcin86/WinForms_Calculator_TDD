using Unity;

namespace CalculatorLogic
{
    public abstract class MathematicalOperationBase
    {
        protected ICalculatorLogic calculatorLogic = null;

        protected MathematicalOperationBase(ICalculatorLogic calculatorLogic)
        {
            this.calculatorLogic = calculatorLogic;
        }

        public abstract float CalculateResult(float lhs, float rhs);
    }
}
