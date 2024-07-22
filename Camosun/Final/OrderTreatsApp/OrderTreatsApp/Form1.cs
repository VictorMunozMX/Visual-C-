using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTreatsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string ord = listBox1.SelectedItem.ToString();
            string qua = comboBox1.SelectedItem.ToString();

            string cad = ord + " quantity: " + qua + Environment.NewLine;

            textBox1.Text += cad;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.ClearSelected();
            comboBox1.SelectedIndex = 0;
        }
    }
}
