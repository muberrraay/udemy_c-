using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;

            misir = Convert.ToInt16(mısırr.Text);
            su = Convert.ToInt16(suu.Text);
            cay = Convert.ToInt16(cayy.Text);
            bilet = Convert.ToInt16(bilett.Text);

            toplam = 8 * bilet + 2 * cay + 1 * su + 4 * misir;
            kasa += toplam;
            lbltoplam.Text = toplam.ToString();
            lblkasa.Text = kasa.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            mısırr.Text = "";
            suu.Text = "";
            bilett.Text = "";
            cayy.Text = "";
            mısırr.Focus();
        }
    }
}
