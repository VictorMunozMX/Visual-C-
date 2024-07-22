namespace ChangeColoursApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGreen.Location = new System.Drawing.Point(136, 205);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(120, 41);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGray.Location = new System.Drawing.Point(340, 205);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(120, 41);
            this.btnGray.TabIndex = 1;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYellow.Location = new System.Drawing.Point(544, 205);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(120, 41);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntReset.Location = new System.Drawing.Point(340, 303);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(120, 40);
            this.bntReset.TabIndex = 3;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnGreen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Change App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGreen;
        private Button btnGray;
        private Button btnYellow;
        private Button bntReset;
    }
}