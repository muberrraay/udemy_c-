using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba mrc = new Araba();

            mrc.renk = "Kırmızı";
            mrc.hiz = 250;
            mrc.motor = 2.1;
            mrc.durum = 'i';
            mrc.fiyat = 150000;
            mrc.YIL = -2018;
            mrc.MARKA = "mercedes";
            mrc.plaka = "34 MY 60";
            mrc.muayene = 2017;
            mrc.sahip = "mubu";


            label1.Text = mrc.renk;
            label2.Text = mrc.hiz.ToString();
            label3.Text = mrc.motor.ToString();
            label4.Text = mrc.durum.ToString();
            label5.Text = mrc.fiyat.ToString();
            label6.Text = mrc.YIL.ToString();
            label7.Text = mrc.MARKA;
            label8.Text = mrc.plaka;
            label9.Text = mrc.muayene.ToString();
            label10.Text = mrc.sahip;

            pictureBox1.BackColor = Color.Red;
        }
    }
}
