namespace checkbox_radiobutton_richtextbox_panel_groupbox
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
            this.hardal = new System.Windows.Forms.CheckBox();
            this.ketçap = new System.Windows.Forms.CheckBox();
            this.mayonez = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hardal);
            this.groupBox1.Controls.Add(this.ketçap);
            this.groupBox1.Controls.Add(this.mayonez);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "soslar";
            // 
            // hardal
            // 
            this.hardal.AutoSize = true;
            this.hardal.Location = new System.Drawing.Point(16, 116);
            this.hardal.Name = "hardal";
            this.hardal.Size = new System.Drawing.Size(55, 17);
            this.hardal.TabIndex = 2;
            this.hardal.Text = "hardal";
            this.hardal.UseVisualStyleBackColor = true;
            // 
            // ketçap
            // 
            this.ketçap.AutoSize = true;
            this.ketçap.Location = new System.Drawing.Point(16, 70);
            this.ketçap.Name = "ketçap";
            this.ketçap.Size = new System.Drawing.Size(59, 17);
            this.ketçap.TabIndex = 1;
            this.ketçap.Text = "ketçap";
            this.ketçap.UseVisualStyleBackColor = true;
            // 
            // mayonez
            // 
            this.mayonez.AutoSize = true;
            this.mayonez.Location = new System.Drawing.Point(16, 29);
            this.mayonez.Name = "mayonez";
            this.mayonez.Size = new System.Drawing.Size(68, 17);
            this.mayonez.TabIndex = 0;
            this.mayonez.Text = "mayonez";
            this.mayonez.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(318, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 97);
            this.panel1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(309, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 134);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox hardal;
        private System.Windows.Forms.CheckBox ketçap;
        private System.Windows.Forms.CheckBox mayonez;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

