using System;

namespace CalculatorLogic.Logic
{
    public class DefaultImplementation : ICalculatorLogic
    {
        public float Add(float lhs, float rhs)
        {
            // check against overflow
            if ((lhs + rhs) > float.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            return lhs + rhs;
        }

        public float Subtract(float lhs, float rhs)
        {
            // check against underflow
            if ((lhs - rhs) < float.MinValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            return lhs - rhs;
        }

        public float Divide(float lhs, float rhs)
        {
            if (0 == rhs)
            {
                throw new DivideByZeroException();
            }

            if ((Math.Round((lhs / rhs)) > float.MaxValue))
            {
                throw new ArgumentOutOfRangeException();
            }

            float result = (float)Math.Round((lhs / rhs), 3);

            return result;
        }

        public float Multiply(float lhs, float rhs)
        {
            if ((Math.Round((lhs * rhs)) > float.MaxValue))
            {
                throw new ArgumentOutOfRangeException();
            }

            float result = (float)Math.Round((lhs * rhs), 3);

            return result;
        }
    }
}
