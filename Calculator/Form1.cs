namespace Calculator
{
    public partial class Form1 : Form
    {
        private double Result { get; set; }
        private double Value { get; set; }
        private Operations OperationSelected { get; set; }

        /// <summary>
        /// ENUM for the operations
        /// </summary>
        private enum Operations
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the zero button click event
        /// </summary>
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length != 1)
            {
                txtDisplay.Text += "0";
            }
        }

        /// <summary>
        /// Handles the one button click event
        /// </summary>
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        /// <summary>
        /// Handles the two button click event
        /// </summary>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        /// <summary>
        /// Handles the three button click event
        /// </summary>
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        /// <summary>
        /// Handles the four button click event
        /// </summary>
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        /// <summary>
        /// Handles the five button click event
        /// </summary>
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        /// <summary>
        /// Handles the six button click event
        /// </summary>
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        /// <summary>
        /// Handles the seven button click event
        /// </summary>
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        /// <summary>
        /// Handles the eight button click event
        /// </summary>
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        /// <summary>
        /// Handles the nine button click event
        /// </summary>
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        /// <summary>
        /// Handles the addition button click event
        /// </summary>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperationSelected = Operations.Addition;
            Value = Convert.ToDouble(txtDisplay.Text);
            lblOperation.Text = "+";
            txtDisplay.Text = string.Empty;
        }

        /// <summary>
        /// Handles the subtraction button click event
        /// </summary>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperationSelected = Operations.Subtraction;
            Value = Convert.ToDouble(txtDisplay.Text);
            lblOperation.Text = "-";
            txtDisplay.Text = string.Empty;
        }

        /// <summary>
        /// Handles the multiplication button click event
        /// </summary>
        private void btnTimes_Click(object sender, EventArgs e)
        {
            OperationSelected = Operations.Multiplication;
            Value = Convert.ToDouble(txtDisplay.Text);
            lblOperation.Text = "X";
            txtDisplay.Text = string.Empty;
        }

        /// <summary>
        /// Handles the division button click event
        /// </summary>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperationSelected = Operations.Division;
            Value = Convert.ToDouble(txtDisplay.Text);
            lblOperation.Text = "/";
            txtDisplay.Text = string.Empty;
        }

        /// <summary>
        /// Handles the equals button click event
        /// </summary>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (OperationSelected)
            {
                case Operations.Addition:
                    Result = Value + Convert.ToDouble(txtDisplay.Text);
                    break;
                case Operations.Subtraction:
                    Result = Value - Convert.ToDouble(txtDisplay.Text);
                    break;
                case Operations.Multiplication:
                    Result = Value * Convert.ToDouble(txtDisplay.Text);
                    break;
                case Operations.Division:
                    Result = Value / Convert.ToDouble(txtDisplay.Text);
                    break;
            }
            lblOperation.Text = "=";
            txtDisplay.Text = Convert.ToString(Result);
        }

        /// <summary>
        /// Handles the comma button click event
        /// </summary>
        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        /// <summary>
        /// Handles the clear button click event
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            lblOperation.Text = string.Empty;
        }
    }
}
