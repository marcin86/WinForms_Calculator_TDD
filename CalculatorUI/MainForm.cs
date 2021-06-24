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
            string last_line = txtDisplay.Lines[txtDisplay.Lines.Length - 1];

            if (regex.AreBothOperantsPresent(last_line))
            {
                rhs_operant = regex.TakeLastOperantValue(last_line);

                float result = currentOperation.CalculateResult(lhs_operant, rhs_operant);

                lhs_operant = result;
                rhs_operant = float.NaN;
                currentOperation = null;

                txtDisplay.Text += $" = {result}{Environment.NewLine}{lhs_operant}";
            }
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string symbol = ((Button)sender).Text;
            MathematicalOperationBase operation = new OperationAddition(logic);

            CommonOperationButtonsFunctionality(operation, symbol);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string symbol = ((Button)sender).Text;
            MathematicalOperationBase operation = new OperationSubtraction(logic);

            CommonOperationButtonsFunctionality(operation, symbol);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string symbol = ((Button)sender).Text;
            MathematicalOperationBase operation = new OperationMultiplication(logic);

            CommonOperationButtonsFunctionality(operation, symbol);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string symbol = ((Button)sender).Text;
            MathematicalOperationBase operation = new OperationDivision(logic);

            CommonOperationButtonsFunctionality(operation, symbol);
        }

        private void CommonOperationButtonsFunctionality(MathematicalOperationBase operation, string symbol)
        {
            string last_line = txtDisplay.Lines[txtDisplay.Lines.Length - 1];

            if (regex.IsLhsOperantPresent(last_line))
            {
                lhs_operant = float.Parse(last_line);

                currentOperation = operation;
                txtDisplay.Text += $" {symbol} ";
            }
            else if (regex.AreBothOperantsPresent(last_line))
            {
                rhs_operant = regex.TakeLastOperantValue(last_line);
                btnEqualSign_Click(null, EventArgs.Empty);
            }
        }
    }
}
