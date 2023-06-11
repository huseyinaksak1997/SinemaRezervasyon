using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SinemaRezervasyonuSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Koltuk koltuk1 = new Koltuk();
            koltuk1.KoltukNo = 1;
            koltuk1.SiraNo = 1;
            koltuk1.YerAyirma();



            Gosterim gosterim1 = new Gosterim();
            gosterim1.FilmAdi = "yüzüklerin efendisi";
            gosterim1.SalonNo = "1";
            gosterim1.Seans = "14.40";
            gosterim1.koltukList.Add(koltuk1);
            Console.WriteLine("gosterim 1 koltuk no:"+gosterim1.koltukList[0].KoltukNo);
            Console.WriteLine("gosterim 1 sıra no "+gosterim1.koltukList[0].SiraNo);

            Bilet bilet1 = new Bilet();
            bilet1.Ad = "mustafa";
            bilet1.Soyad = "yılmaz";
            bilet1.TcNo = "1111111111";
            bilet1.Fiyat = 14.99;
            bilet1.koltukList.Add(koltuk1);
            bilet1.gosterimList.Add(gosterim1);
            bilet1.BilgiYazdir();
            
            IndirimliBilet indirimliBilet1 = new IndirimliBilet();
            indirimliBilet1.Ad = "ahmet";
            indirimliBilet1.Soyad = "erdogan";
            indirimliBilet1.TcNo = "99999999999";
            indirimliBilet1.Fiyat = 9.99;
            indirimliBilet1.IndirimKodu = "54654";
            indirimliBilet1.IndirimMiktari = 5;
            indirimliBilet1.koltukList.Add(koltuk1);
            indirimliBilet1.gosterimList.Add(gosterim1);
            Console.WriteLine("film adi :"+indirimliBilet1.gosterimList[0].FilmAdi);
            Console.WriteLine("salon no :"+indirimliBilet1.gosterimList[0].SalonNo);
            Console.WriteLine("seans    :"+indirimliBilet1.gosterimList[0].Seans);
            indirimliBilet1.BilgiYazdir();

            Console.ReadKey();
        }
    }
}
