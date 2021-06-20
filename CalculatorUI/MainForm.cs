using CalculatorLogic.Operations;
using CalculatorLogic.Logic;
using System;
using System.Windows.Forms;
using CalculatorLogic.RegexAnalyzer;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        private ICalculatorLogic logic = null;
        private IRegexOperations regex = null;
        private MathematicalOperationBase currentOperation = null;

        private float lhs_operant = float.NaN, rhs_operant = float.NaN;

        public MainForm(ICalculatorLogic logic, IRegexOperations regex)
        {
            InitializeComponent();
            this.logic = logic;
            this.regex = regex;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOperation = new OperationAddition(logic);
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            currentOperation = new OperationSubtraction(logic);
        }
    }
}
