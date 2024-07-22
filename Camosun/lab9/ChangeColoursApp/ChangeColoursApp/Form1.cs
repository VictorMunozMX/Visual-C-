namespace ChangeColoursApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Green;
            MessageBox.Show("Colour selection was: Color [Green]");
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Gray;
            MessageBox.Show("Colour selection was: Color [Gray]");
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Yellow;
            MessageBox.Show("Colour selection was: Color [Yellow]");
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.DarkBlue;            
        }
    }
}