using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace PizzaOrderMenu
{
    public partial class Form1 : Form
    {
        float total;
        string size, selectedPizza, pizzaToppings, selectedBeverage, selectedDessert;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brought to you by the brothers Mario\r\nand Luigi!");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdoSmallSize.Checked = false;
            rdoMediumSize.Checked = false;
            rdoLargeSize.Checked = false;
            chkMushroom.Checked = false;
            chkOlive.Checked = false;
            chkPepperoni.Checked = false;
            chkCola.Checked = false;
            chkJuice.Checked = false;
            chkChocolate.Checked = false;
            chkApple.Checked = false;
            txtOrder.Text = "";
            txtTotal.Text = "";
            cboDietary.SelectedIndex = 0;
        }

        private void cboDietary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diet = cboDietary.SelectedItem.ToString();

            ArrayList pizzaType = new ArrayList {"Cheese","Hawaiian","Margherita","Marinara",
                "Neapolitan","Lahma Bi Ajeen","Calzone",
                "Stromboli","Deep Dish","The M&L Special"};

            switch (diet)
            {
                case "Vegan":
                case "Vegetarian":
                    pizzaType.Remove("Hawaiian");
                    pizzaType.Remove("Calzone");
                    pizzaType.Remove("Stromboli");
                    pizzaType.Remove("Lahma Bi Ajeen");
                    pizzaType.Remove("The M&L Special");
                    break;
                case "Non-GMO":
                    pizzaType.Remove("Stromboli");
                    break;
                case "Gluten free":
                case "Lactose":
                case "Paleo":
                    pizzaType.Remove("Cheese");
                    pizzaType.Remove("Neapolitan");
                    pizzaType.Remove("Margherita");
                    pizzaType.Remove("Deep Dish");
                    break;
                case "100 mile":
                case "Koshe":
                    pizzaType.Remove("Hawaiian");
                    pizzaType.Remove("Stromboli");
                    break;
            }
            pizzaType.Sort();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(pizzaType.Cast<object>().ToArray());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPizza = listBox1.SelectedItem.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            total = 0f;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {

            // Calculate cost
            if (rdoSmallSize.Checked || rdoMediumSize.Checked || rdoLargeSize.Checked)
                txtTotal.Text = String.Format("{0:C}", CalculatePizzaCost());

            // label by size
            size = "";
            if (rdoSmallSize.Checked)
            {
                size = "Small";
            }
            if (rdoMediumSize.Checked)
            {
                size = "Medium";
            }
            if (rdoLargeSize.Checked)
            {
                size = "Large";
            }
            // text in the txt order
            txtOrder.Text = selectedPizza + Environment.NewLine +
                   "Size: " + size + Environment.NewLine +
                   "Toppings: " + pizzaToppings + Environment.NewLine +
                   "Drinks: " + selectedBeverage + Environment.NewLine +
                   "Dessert: " + selectedDessert;
        }

        public float CalculatePizzaCost()
        {
            // type of pizza
            switch (selectedPizza)
            {
                case "Cheese":
                    total = 10;
                    break;
                case "Neapolitan":
                    total = 10;
                    break;
                case "Margherita":
                    total = 10;
                    break;
                case "Calzone":
                    total = 12.50f;
                    break;
                case "Stromboli":
                    total = 12.5f;
                    break;
                case "Deep Dish":
                    total = 12.5f;
                    break;
                case "Marinara":
                    total = 12.5f;
                    break;
                case "Hawaiian":
                    total = 12.5f;
                    break;
                case "Lahma Bi Ajeen":
                    total = 13;
                    break;
                case "The M&L Special":
                    total = 14;
                    break;
            }

            // pizza size
            if (rdoSmallSize.Checked)
            {
                total = total - 2;
            }
            if (rdoMediumSize.Checked)
            {
                //total = 15;
            }
            if (rdoLargeSize.Checked)
            {
                total = total + 5;
            }

            // toppings            
            if (!chkMushroom.Checked && !chkOlive.Checked && !chkPepperoni.Checked)
            {
                pizzaToppings = "none";
            }
            else
            {
                if (chkMushroom.Checked && chkOlive.Checked && chkPepperoni.Checked)
                {
                    pizzaToppings = "Mushroom, Black Olive, Pepperoni";
                    total = total + 10;                    
                }
                else
                {
                    if (chkMushroom.Checked && chkOlive.Checked)
                    {                        
                        pizzaToppings = "Mushroom, Black Olive";
                        total = total + 5;
                    }
                    if (chkMushroom.Checked && chkPepperoni.Checked)
                    {                        
                        pizzaToppings = "Mushroom, Pepperoni";
                        total = total + 7;
                    }
                    if (chkOlive.Checked && chkPepperoni.Checked)
                    {                        
                        pizzaToppings = "Black Olive, Pepperoni";
                        total = total + 8;
                    }

                    if (chkMushroom.Checked && !chkOlive.Checked && !chkPepperoni.Checked)
                    {                     
                        total = total + 2;
                        pizzaToppings = "Mushroom";
                    }
                    if (chkOlive.Checked && !chkMushroom.Checked && !chkPepperoni.Checked)
                    {                     
                        total = total + 3;
                        pizzaToppings = "Black Olive";
                    }
                    if (!chkMushroom.Checked && !chkOlive.Checked && chkPepperoni.Checked)
                    {                        
                        total = total + 5;
                        pizzaToppings = "Pepperoni";
                    }
                }
            }

            //drinks
            if (chkCola.Checked && chkJuice.Checked)
            {
                total = total + 5.5f;
                selectedBeverage = "+Cola, Juice";
            }
            if (chkCola.Checked && !chkJuice.Checked) 
            {
                total = total + 2.5f;
                selectedBeverage = "+Cola";
            }
            if (chkJuice.Checked && !chkCola.Checked)
            {
                total = total + 3;
                selectedBeverage = "+Juice";
            }
            // dessert
            if (chkApple.Checked && chkChocolate.Checked)
            {
                total = total + 7;
                selectedDessert = "Apple Pie, Chocolate cake";
            }
            if (chkApple.Checked && !chkChocolate.Checked)
            {
                total = total + 3;
                selectedDessert = "Apple Pie";
            }
            if (chkChocolate.Checked && !chkApple.Checked)
            {
                total = total + 4;
                selectedDessert = "Chocolate Cake";
            }            
            return total;
        }
    }
}