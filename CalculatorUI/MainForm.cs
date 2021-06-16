using CalculatorLogic;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        ICalculatorLogic logic = null;
        MathematicalOperationBase currentOperation = null;

        private float lhs_operant = float.NaN, rhs_operant = float.NaN;

        public MainForm(ICalculatorLogic logic)
        {
            InitializeComponent();

            this.logic = logic;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            if (lhs_operant == float.NaN && currentOperation == null && txtDisplay.Text == string.Empty)
            {
                return;
            }
            DisplayContentToVariable();

            lhs_operant = currentOperation.CalculateResult(lhs_operant, rhs_operant);
            rhs_operant = float.NaN;

            txtDisplay.Text = lhs_operant.ToString();
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommonOperationButtonOperations();
            currentOperation = new OperationAddition(logic);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            CommonOperationButtonOperations();
            currentOperation = new OperationSubtraction(logic);
        }

        private void DisplayContentToVariable()
        {
            if (null == currentOperation)
            {
                bool result = float.TryParse(txtDisplay.Text, out lhs_operant);
            }
            else
            {
                bool result = float.TryParse(txtDisplay.Text, out rhs_operant);
            }

            txtDisplay.Text = string.Empty;
        }

        private void CommonOperationButtonOperations()
        {
            if (!float.IsNaN(lhs_operant) && !float.IsNaN(rhs_operant) && currentOperation != null)
            {
                btnEqualSign_Click(this, EventArgs.Empty);
                return;
            }

            DisplayContentToVariable();
        }
    }
}
