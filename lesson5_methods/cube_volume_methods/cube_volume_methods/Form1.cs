using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cube_volume_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cube(int a)
        {
            int hacim = a * a * a;
            return hacim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1= Convert.ToInt16(textBox1.Text);
            
            label2.Text=cube(sayi1).ToString();

        }
    }
}
