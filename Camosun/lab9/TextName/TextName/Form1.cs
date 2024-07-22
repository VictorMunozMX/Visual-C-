namespace TextName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "This lab completed by " + txtName.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}