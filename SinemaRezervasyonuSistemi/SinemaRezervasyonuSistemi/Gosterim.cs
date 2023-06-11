using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezervasyonuSistemi
{
    class Gosterim
    {
        protected string filmAdi;
        protected string seans;
        protected string tarih;
        protected string salonNo;

        public string FilmAdi { get => filmAdi; set => filmAdi = value; }
        public string Seans { get => seans; set => seans = value; }
        public string Tarih { get => tarih; set => tarih = value; }
        public string SalonNo { get => salonNo; set => salonNo = value; }

        public List<Koltuk> koltukList = new List<Koltuk>();

        

    }
}
