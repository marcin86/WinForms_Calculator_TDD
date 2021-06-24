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
            throw new NotImplementedException();
        }

        public float Multiply(float lhs, float rhs)
        {
            throw new NotImplementedException();
        }
    }
}
