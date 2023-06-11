using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezervasyonuSistemi
{
    public class Koltuk
    {
        private int siraNo;
        private int koltukNo;
        public Boolean durum = false; //dolu veya bos olduğunu belirtir

        public int SiraNo { get => siraNo; set => siraNo = value; }
        public int KoltukNo { get => koltukNo; set => koltukNo = value; }

        public void YerAyirma()
        {
            durum = true;
            
        }
            
    }
}
