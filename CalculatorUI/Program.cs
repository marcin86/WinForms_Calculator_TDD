using CalculatorLogic;
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
            // DI container
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICalculatorLogic, DefaultImplementation>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(container.Resolve<ICalculatorLogic>()));
        }
    }
}
