namespace LabEx1
{
    partial class Currency_Converter
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(97, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(179, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Choose Currency";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.AllowDrop = true;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "AUS Dollar",
            "CAN",
            "EURO",
            "UK Pounds",
            "US Dollar"});
            this.cmbCurrency.Location = new System.Drawing.Point(315, 76);
            this.cmbCurrency.MinimumSize = new System.Drawing.Size(166, 0);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(166, 33);
            this.cmbCurrency.TabIndex = 2;
            this.cmbCurrency.Text = "Currency";
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbl2.AutoSize = true;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbl2.Location = new System.Drawing.Point(97, 185);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(215, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Enter Amount in USD";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(610, 185);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(73, 25);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Result";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(193, 297);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(191, 136);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Currency_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 746);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "Currency_Converter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Currency_Converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnConvert;
    }
}

