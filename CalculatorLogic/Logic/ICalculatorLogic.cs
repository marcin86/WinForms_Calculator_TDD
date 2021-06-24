namespace CalculatorLogic.Logic
{
    public interface ICalculatorLogic
    {
        float Add(float rhs, float lhs);

        float Subtract(float lhs, float rhs);

        float Divide(float lhs, float rhs);

        float Multiply(float lhs, float rhs);
    }
}
