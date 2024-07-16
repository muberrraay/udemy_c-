using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_classes
{
    internal class Araba : ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private String marka;

        public int YIL

        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA {
            get { return marka; } 
            set { marka = value.ToUpper(); } 
        }
    }
}
