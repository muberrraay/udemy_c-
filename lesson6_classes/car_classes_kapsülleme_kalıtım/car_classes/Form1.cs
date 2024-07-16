using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba bmw = new Araba();

            bmw.renk = "Mavi";
            bmw.hiz = 200;
            bmw.motor = 1.8;
            bmw.durum = 's';
            bmw.fiyat = 180000;
            bmw.YIL = -2016;
            bmw.MARKA = "bmw";
            bmw.plaka = "34 MY 43";
            bmw.muayene = 2017;
            bmw.sahip = "mubu";

            label1.Text = bmw.renk;
            label2.Text = bmw.hiz.ToString();
            label3.Text = bmw.motor.ToString();
            label4.Text = bmw.durum.ToString();
            label5.Text = bmw.fiyat.ToString();
            label6.Text= bmw.YIL.ToString();
            label7.Text = bmw.MARKA;
            label8.Text = bmw.plaka;
            label9.Text= bmw.muayene.ToString();
            label10.Text = bmw.sahip;

            pictureBox1.BackColor = Color.Blue;
        }
    }
}
