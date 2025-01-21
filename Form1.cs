namespace Calculadora {
    public partial class Form1 : Form {

        public decimal Result { get; set; }

        public decimal Value { get; set; }
        private Operation SelectedOperation { get; set; }
        private enum Operation {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }
        public Form1() {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e) {
            textResult.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e) {
            textResult.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e) {
            textResult.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e) {
            textResult.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e) {
            textResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e) {
            textResult.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e) {
            textResult.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            textResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e) {
            textResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e) {
            textResult.Text += "9";
        }

        private void btnAddition_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Addition;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperation.Text = "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Subtraction;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperation.Text = "-";
        }

        private void btnMultiplication_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Multiplication;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperation.Text = "X";
        }

        private void btnDivision_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Division;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperation.Text = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e) {
            switch (SelectedOperation) {
                case Operation.Addition:
                    Result = Value + Convert.ToDecimal(textResult.Text);
                    break;
                case Operation.Subtraction:
                    Result = Value - Convert.ToDecimal(textResult.Text);
                    break;
                case Operation.Multiplication:
                    Result = Value * Convert.ToDecimal(textResult.Text);
                    break;
                case Operation.Division:
                    Result = Value / Convert.ToDecimal(textResult.Text);
                    break;
            }
            textResult.Text = Convert.ToString(Result);
        }

        private void btnComma_Click(object sender, EventArgs e) {
            if (!textResult.Text.Contains(","))
                textResult.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e) {
            textResult.Text = "";
            lblOperation.Text = "";
        }
    }
}
