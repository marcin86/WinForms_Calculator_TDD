using CalculatorLogic.Logic;
using CalculatorLogic.RegexAnalyzer;
using System;
using System.Windows.Forms;
using Unity;

namespace CalculatorUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Correct way to use DI container
            // https://www.devtrends.co.uk/blog/how-not-to-do-dependency-injection-the-static-or-singleton-container
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICalculatorLogic, DefaultImplementation>();
            container.RegisterType<IRegexOperations, RegexImplementation>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(container.Resolve<MainForm>());
        }
    }
}
