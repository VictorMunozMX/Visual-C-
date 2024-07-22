namespace FormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double firstNumber;
        private double secondNumber;

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {            
            if (double.TryParse(txtFirst.Text, out firstNumber) && firstNumber < 1)
            {
                lblResult.Text = ("Value must be numeric and > 0.");
                lblResult.ForeColor = Color.Red;
            }
            else { lblResult.Text = ""; }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {            
            if (!double.TryParse(txtSecond.Text, out secondNumber) || secondNumber < 1)
            {
                lblResult.Text = ("Value must be numeric and > 0.");
                lblResult.ForeColor = Color.Red;
            }
            else { lblResult.Text = ""; }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result = " + Multiple().ToString();
            lblResult.ForeColor = Color.Yellow;
        }

        public double Multiple()
        {            
            return firstNumber * secondNumber;
        }
        public double Add()
        {
            return firstNumber + secondNumber;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtSecond.Text = "";
            lblResult.Text = "";
            txtFirst.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result = " + Add().ToString();
            lblResult.ForeColor = Color.Yellow;
        }
    }
}
