using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            timer1.Start();
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            i++;
            label1.Text = i.ToString();
            if (i == 30)
            {
                this.BackColor = Color.Yellow;
            }
            else if (i == 40)
            {
                this.BackColor = Color.Green;
            }
            else if (i== 70)
            {
                this.BackColor = Color.Red;
                i = 0;
            }
        }
    }
}
