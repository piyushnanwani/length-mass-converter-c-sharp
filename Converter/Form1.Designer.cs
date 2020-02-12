namespace WindowsFormsApplication4
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.SelectOption = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectOption)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(168, 12);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(152, 28);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Converter";
            this.ultraLabel1.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // SelectOption
            // 
            valueListItem1.DataValue = "Length";
            valueListItem2.DataValue = "Weight";
            this.SelectOption.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.SelectOption.Location = new System.Drawing.Point(48, 57);
            this.SelectOption.Name = "SelectOption";
            this.SelectOption.Size = new System.Drawing.Size(355, 21);
            this.SelectOption.TabIndex = 1;
            this.SelectOption.Text = "Select option";
            this.SelectOption.ValueChanged += new System.EventHandler(this.showStuff);
            this.SelectOption.Click += new System.EventHandler(this.showStuff);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(48, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.ConvertRight);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ultraLabel2.Location = new System.Drawing.Point(213, 112);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(28, 23);
            this.ultraLabel2.TabIndex = 4;
            this.ultraLabel2.Text = "=";
            this.ultraLabel2.Click += new System.EventHandler(this.ultraLabel2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kilometre",
            "Metre",
            "Centimetre",
            "Millimetre",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.comboBox1.Location = new System.Drawing.Point(48, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Select Unit";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.ConvertRight);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox2.Location = new System.Drawing.Point(246, 103);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 41);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kilometre",
            "Metre",
            "Centimetre",
            "Millimetre",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.comboBox2.Location = new System.Drawing.Point(246, 150);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Select Unit";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.ConvertRight);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tonne",
            "Kilogram",
            "Gram",
            "Milligram",
            "Microgram",
            "Imperial ton",
            "US ton",
            "Stone",
            "Pound"});
            this.comboBox3.Location = new System.Drawing.Point(48, 150);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(155, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.Text = "Select Unit";
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.ConvertRightWeight);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Tonne",
            "Kilogram",
            "Gram",
            "Milligram",
            "Microgram",
            "Imperial ton",
            "US ton",
            "Stone",
            "Pound"});
            this.comboBox4.Location = new System.Drawing.Point(246, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(155, 21);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.Text = "Select Unit";
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedValueChanged += new System.EventHandler(this.ConvertRightWeight);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 268);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectOption);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor SelectOption;
        private System.Windows.Forms.TextBox textBox1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

