using CalculatorLogic;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class MainForm : Form
    {
        ICalculatorLogic logic = null;
        MathematicalOperationBase currentOperation = null;

        private float lhs_operant = 0.0f, rhs_operant = 0.0f, result = 0.0f;

        public MainForm(ICalculatorLogic logic)
        {
            InitializeComponent();

            this.logic = logic;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            if (lhs_operant == 0.0f || rhs_operant == 0.0f || currentOperation == null)
            {
                return;
            }

            result = currentOperation.CalculateResult(lhs_operant, rhs_operant);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOperation = new OperationAddition(logic);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            currentOperation = new OperationSubtraction(logic);
        }
    }
}
