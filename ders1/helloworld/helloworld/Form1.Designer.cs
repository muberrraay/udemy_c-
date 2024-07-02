namespace helloworld
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(288, 233);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 24);
            button1.TabIndex = 0;
            button1.Text = "tiklayin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 1;
            label1.Text = "adınız:";
            // 
            // button2
            // 
            button2.Location = new Point(40, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "yazdir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 93);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 69);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 69);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 5;
            label4.Text = "adiniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 93);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 6;
            label5.Text = "soyadiniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 120);
            label6.Name = "label6";
            label6.Size = new Size(78, 16);
            label6.TabIndex = 7;
            label6.Text = "mesleginiz:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 120);
            label7.Name = "label7";
            label7.Size = new Size(47, 16);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // button3
            // 
            button3.Location = new Point(494, 152);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 9;
            button3.Text = "bilgi getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(52, 191);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 181);
            label8.Name = "label8";
            label8.Size = new Size(48, 16);
            label8.TabIndex = 12;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Ink Free", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Location = new Point(12, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label8;
    }
}
