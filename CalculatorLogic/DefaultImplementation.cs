namespace CalculatorLogic
{
    public class DefaultImplementation : ICalculatorLogic
    {
        public float Add(float lhs, float rhs)
        {
            return lhs + rhs;
        }
    }
}
