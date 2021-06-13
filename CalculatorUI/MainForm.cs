using CalculatorLogic;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        private readonly ICalculatorLogic calculator;

        public MainForm(ICalculatorLogic calculatorLogic)
        {
            InitializeComponent();

            calculator = calculatorLogic;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float result = calculator.Add(1, 2);
        }
    }
}
