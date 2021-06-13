using CalculatorLogic;
using Unity;

namespace WinForms_Calculator_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICalculatorLogic, DefaultImplementation>();

            CalculatorService calculatorService = new CalculatorService(container.Resolve< ICalculatorLogic>());
        }
    }
}
