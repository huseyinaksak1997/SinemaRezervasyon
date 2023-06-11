using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezervasyonuSistemi
{
    class IndirimliBilet:Bilet
    {
        string indirimKodu;
        double indirimMiktari;
        public string IndirimKodu { get => indirimKodu; set => indirimKodu = value; }
        public double IndirimMiktari { get => indirimMiktari; set => indirimMiktari = value; }
        public override void BilgiYazdir()
        {
            Console.WriteLine(ad + "\t" + soyad + "\t" + tcNo + "\t" + fiyat+ "\t"+IndirimMiktari);
        }
        
    }
}
