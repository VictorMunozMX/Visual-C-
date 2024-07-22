namespace SimpleEncoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblEncoded = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOriginal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOriginal.Location = new System.Drawing.Point(89, 58);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(67, 20);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "original";
            // 
            // lblEncoded
            // 
            this.lblEncoded.AutoSize = true;
            this.lblEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncoded.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEncoded.Location = new System.Drawing.Point(498, 58);
            this.lblEncoded.Name = "lblEncoded";
            this.lblEncoded.Size = new System.Drawing.Size(78, 20);
            this.lblEncoded.TabIndex = 1;
            this.lblEncoded.Text = "encoded";
            // 
            // txtOriginal
            // 
            this.txtOriginal.AcceptsReturn = true;
            this.txtOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOriginal.Location = new System.Drawing.Point(89, 92);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginal.Size = new System.Drawing.Size(219, 281);
            this.txtOriginal.TabIndex = 2;
            this.txtOriginal.Text = resources.GetString("txtOriginal.Text");
            // 
            // txtEncoded
            // 
            this.txtEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEncoded.Location = new System.Drawing.Point(498, 92);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncoded.Size = new System.Drawing.Size(219, 281);
            this.txtEncoded.TabIndex = 3;
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncode.Location = new System.Drawing.Point(345, 216);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(118, 33);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblEncoded);
            this.Controls.Add(this.lblOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOriginal;
        private Label lblEncoded;
        private TextBox txtOriginal;
        private TextBox txtEncoded;
        private Button btnEncode;
    }
}