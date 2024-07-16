using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_consolapp_methods
{
    internal class Kisiler
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public string AD {  
            get { return ad; } 
            set { ad = value.ToLower(); } }

        public string SOYAD { 
            get { return soyad; }
            set {  soyad = value.ToUpper(); }

            }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS { 
            get { return yas; } 
            set { yas = Math.Abs(value); } }

        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kisiler()
        {
            ad = " ";
            soyad = " ";
            memleket = "Denizli ";
            yas = 0;
            cinsiyet = 'K';
        }


    }

 
}
