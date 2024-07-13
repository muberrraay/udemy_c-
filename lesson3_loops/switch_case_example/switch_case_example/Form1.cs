using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonucc;
            char a = Convert.ToChar(textBox3.Text);

            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            switch (a) {
                case '+' : sonuc.Text = Convert.ToString(sayi1 + sayi2); break;
                case '-': sonuc.Text = Convert.ToString(sayi1 - sayi2); break;
                case 'x': sonuc.Text = Convert.ToString(sayi1 * sayi2); break;
                case '/': sonuc.Text = Convert.ToString(sayi1 / sayi2); break;
            }
        }
    }
}
