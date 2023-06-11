using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezervasyonuSistemi
{
    class Bilet
    {
        protected string ad;
        protected string soyad;
        protected string tcNo;
        protected double fiyat;
        public string Soyad { get => soyad; set => soyad = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public string Ad { get => ad; set => ad = value; }
        public virtual void BilgiYazdir()
        {
            Console.WriteLine(ad+"\t"+soyad+"\t"+tcNo+"\t"+fiyat);
        }

        public List<Koltuk> koltukList = new List<Koltuk>();     
        public List<Gosterim> gosterimList = new List<Gosterim>();

        

    }
}
