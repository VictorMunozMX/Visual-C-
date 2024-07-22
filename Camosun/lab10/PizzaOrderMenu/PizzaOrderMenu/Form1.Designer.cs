namespace PizzaOrderMenu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.rdoMediumSize = new System.Windows.Forms.RadioButton();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.cboDietary = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.chkApple = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLargeSize);
            this.groupBox1.Controls.Add(this.rdoMediumSize);
            this.groupBox1.Controls.Add(this.rdoSmallSize);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(193, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza size";
            // 
            // rdoLargeSize
            // 
            this.rdoLargeSize.AutoSize = true;
            this.rdoLargeSize.Location = new System.Drawing.Point(25, 67);
            this.rdoLargeSize.Name = "rdoLargeSize";
            this.rdoLargeSize.Size = new System.Drawing.Size(62, 27);
            this.rdoLargeSize.TabIndex = 2;
            this.rdoLargeSize.Text = "large";
            this.rdoLargeSize.UseVisualStyleBackColor = true;
            this.rdoLargeSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoMediumSize
            // 
            this.rdoMediumSize.AutoSize = true;
            this.rdoMediumSize.Location = new System.Drawing.Point(25, 44);
            this.rdoMediumSize.Name = "rdoMediumSize";
            this.rdoMediumSize.Size = new System.Drawing.Size(82, 27);
            this.rdoMediumSize.TabIndex = 1;
            this.rdoMediumSize.Text = "medium";
            this.rdoMediumSize.UseVisualStyleBackColor = true;
            this.rdoMediumSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(25, 19);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(63, 27);
            this.rdoSmallSize.TabIndex = 0;
            this.rdoSmallSize.Text = "small";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            this.rdoSmallSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(496, 293);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 36);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(496, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPepperoni);
            this.groupBox2.Controls.Add(this.chkOlive);
            this.groupBox2.Controls.Add(this.chkMushroom);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(338, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(26, 71);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(95, 27);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(26, 48);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(96, 27);
            this.chkOlive.TabIndex = 1;
            this.chkOlive.Text = "Black olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(26, 25);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(97, 27);
            this.chkMushroom.TabIndex = 0;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Cheese",
            "Hawaiian",
            "Margherita",
            "Neapolitan",
            "Lahma Bi Ajeen",
            "Calzone",
            "Stromboli",
            "Deep dish",
            "The M&L Special"});
            this.listBox1.Location = new System.Drawing.Point(26, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 108);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(495, 106);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(142, 97);
            this.txtOrder.TabIndex = 5;
            // 
            // cboDietary
            // 
            this.cboDietary.FormattingEnabled = true;
            this.cboDietary.Items.AddRange(new object[] {
            "",
            "100 Mile",
            "Gluten free",
            "Kosher",
            "Lactose",
            "Non-GMO",
            "Paleo",
            "Vegan",
            "Vegetarian"});
            this.cboDietary.Location = new System.Drawing.Point(255, 45);
            this.cboDietary.Name = "cboDietary";
            this.cboDietary.Size = new System.Drawing.Size(142, 21);
            this.cboDietary.TabIndex = 6;
            this.cboDietary.SelectedIndexChanged += new System.EventHandler(this.cboDietary_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "If you have a Diatery Restriction:";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem1,
            this.resetToolStripMenuItem});
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pizzaToolStripMenuItem.Text = "&Order";
            // 
            // pizzaToolStripMenuItem1
            // 
            this.pizzaToolStripMenuItem1.Name = "pizzaToolStripMenuItem1";
            this.pizzaToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.pizzaToolStripMenuItem1.Text = "&Pizza";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(663, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(193, 227);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(203, 102);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkJuice);
            this.tabPage1.Controls.Add(this.chkCola);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(195, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Beverage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkJuice
            // 
            this.chkJuice.AutoSize = true;
            this.chkJuice.Location = new System.Drawing.Point(7, 32);
            this.chkJuice.Name = "chkJuice";
            this.chkJuice.Size = new System.Drawing.Size(63, 27);
            this.chkJuice.TabIndex = 1;
            this.chkJuice.Text = "Juice";
            this.chkJuice.UseVisualStyleBackColor = true;
            this.chkJuice.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Location = new System.Drawing.Point(7, 8);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(59, 27);
            this.chkCola.TabIndex = 0;
            this.chkCola.Text = "Cola";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkChocolate);
            this.tabPage2.Controls.Add(this.chkApple);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(195, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dessert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(7, 32);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(131, 27);
            this.chkChocolate.TabIndex = 1;
            this.chkChocolate.Text = "Chocolate cake";
            this.chkChocolate.UseVisualStyleBackColor = true;
            this.chkChocolate.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // chkApple
            // 
            this.chkApple.AutoSize = true;
            this.chkApple.Location = new System.Drawing.Point(7, 8);
            this.chkApple.Name = "chkApple";
            this.chkApple.Size = new System.Drawing.Size(89, 27);
            this.chkApple.TabIndex = 0;
            this.chkApple.Text = "Apple Pie";
            this.chkApple.UseVisualStyleBackColor = true;
            this.chkApple.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(495, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Our Pizzas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(663, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDietary);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M&L Pizza Palace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLargeSize;
        private System.Windows.Forms.RadioButton rdoMediumSize;
        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.ComboBox cboDietary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.CheckBox chkApple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}