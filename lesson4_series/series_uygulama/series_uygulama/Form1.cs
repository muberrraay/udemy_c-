﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace series_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int k = 0;
            int toplam = 0;

            foreach (int i in sayilar)
            {
                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                    k++;
                }
                label1.Text= k.ToString();
                label2.Text= toplam.ToString();


            }
        }
    }
}
