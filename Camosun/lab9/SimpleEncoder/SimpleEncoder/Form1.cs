namespace SimpleEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string originalString = txtOriginal.Text;
            string codedString = "";
            char codedChar;

            foreach(char c in originalString)
            {                
                if (c >= 'a' && c <= 'z')
                {
                    codedChar = Convert.ToChar((c-'a'+1) % 26 +'a');
                    codedString = codedString + codedChar.ToString();
                }
                else
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        codedChar = Convert.ToChar((c - 'A' + 1) % 26 + 'A');
                        codedString = codedString + codedChar.ToString();
                    }
                    else
                    {
                        codedString = codedString + c;
                    }
                }
            }
            txtEncoded.Text = codedString;
        }
    }
}