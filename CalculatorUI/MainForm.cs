using CalculatorLogic;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        private ICalculatorLogic logic = null;
        private MathematicalOperationBase currentOperation = null;

        private float lhs_operant = float.NaN, rhs_operant = float.NaN;

        public MainForm(ICalculatorLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            if (null != currentOperation && !float.IsNaN(lhs_operant) && float.TryParse(txtDisplay.Text, out rhs_operant))
            {
                lhs_operant = currentOperation.CalculateResult(lhs_operant, rhs_operant);
                txtDisplay.Text = string.Empty;
                txtHistory.Text += $" {rhs_operant} = {lhs_operant}{Environment.NewLine}{lhs_operant}";

                rhs_operant = float.NaN;
                currentOperation = null;
            }
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (null == currentOperation && float.IsNaN(lhs_operant))
            {
                float.TryParse(txtDisplay.Text, out lhs_operant);
                txtDisplay.Text = string.Empty;
                txtHistory.Text += $"{lhs_operant} {((Button)sender).Text}";
            }
            else
            {
                float.TryParse(txtDisplay.Text, out rhs_operant);
                txtHistory.Text += $" {((Button)sender).Text} ";
                btnEqualSign_Click(sender, EventArgs.Empty);
            }

            currentOperation = new OperationAddition(logic);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            currentOperation = new OperationSubtraction(logic);
        }
    }
}
